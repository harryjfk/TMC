Attribute VB_Name = "Mod_BalanceCarga"
Option Explicit

'''************************************************************************************************************************
'''' ====================    Modulo de calculo del Balance de Materiales en HAE    =======================================
'''************************************************************************************************************************



'' ======================   variables internas de calculo   ======================
Public Peso_Carga_MetalicaTotal As Single, Peso_Cal As Single, Peso_Dolomita As Single, Peso_Carbon As Single
Public Peso_EscoriaRem As Single

'' ======================   variables generales modificables por el usuario   ======================
Public BaseAcero As Single, BaseEscoria As Single, AcLiquido As Single
Public Cal_MasaTotal As Single, Dolomita_MasaTotal As Single, Carbon_MasaTotal As Single, Carga_MetalicaTotal As Single
Public PieL_MasaTotal As Single, EscoriaRem_MasaTotal As Single

'' ======================   variables modificables por el usuario   ======================
''' Oxidos de la Escoria
Dim SiO2_Esc As Single, Al2O3_Esc As Single, FeO_Esc As Single, S_Esc As Single, Cr2O3_Esc As Single
Dim CaO_Esc As Single, MgO_Esc As Single, MnO_Esc As Single, P2O5_Esc As Single, C_Esc As Single, Otros_Esc As Single

''' Elementos en el metal liquido  ''' en pociento
Dim C_Metal As Single, Mn_Metal As Single, Si_Metal As Single, P_Metal As Single, S_Metal As Single, Fe_Metal As Single
Dim Al_Metal As Single, Ni_Metal As Single, Cr_Metal As Single, Cu_Metal As Single

''' Elementos del Pie Liquido
Dim C_PieL As Single, Mn_PieL As Single, Si_PieL As Single, P_PieL As Single, S_PieL As Single, Fe_PieL As Single
Dim Al_PieL As Single, Ni_PieL As Single, Cr_PieL As Single, Cu_PieL As Single

''' Conposicion de carga
Dim Masa_HBI As Single, Masa_ChatarraLigera As Single, Masa_Escarpa As Single, Masa_HierroFundido As Single
Dim Masa_ChatarraPesada As Single, Masa_Paca As Single, Masa_PieLiquido As Single, Masa_HRD As Single

''' eficiencia del oxigeno inyectado
Public Oxigeno_EficInyectado As Single

''' estimacion de gases
Public CO As Single, CO2 As Single
Public Dens_CO As Single, Dens_CO2 As Single

''' composicion del Aire
Public Aire_Comp As Single, Nitrogeno_Aire As Single, Oxigeno_Aire As Single
Public Dens_Aire As Single, Dens_Nitrogeno As Single, Dens_Oxigeno As Single
Public Vol_Aire As Single, Vol_Nitrogeno As Single, Vol_Oxigeno As Single



Dim i As Integer



''' funcion para calcular la carga en funcion de la composicion quinica del metal y la escoria
Public Sub Escoria_Segun_Carga_Metal()
Dim Entradas As Single, Salidas As Single
Dim HBI_AcL As Single, ChatarraLigera_AcL As Single, Escarpa_AcL As Single, HierroFundido_AcL As Single
Dim ChatarraPesada_AcL As Single, Paca_AcL As Single, PieLiquido_AcL As Single, HRD_AcL As Single

Dim C_AcL As Single, Mn_AcL As Single, Si_AcL As Single, P_AcL As Single, S_AcL As Single, Fe_AcL As Single
Dim Al_AcL As Single, Ni_AcL As Single, Cr_AcL As Single, Cu_AcL As Single

''' masas de la carga en Toneladas
Masa_HBI = 0: Masa_ChatarraLigera = 53.1: Masa_Escarpa = 13.1: Masa_HierroFundido = 8.6
Masa_ChatarraPesada = 0: Masa_Paca = 0: Masa_PieLiquido = 7: Masa_HRD = 0
''' composicion del acero en %
C_Metal = 0.09: Mn_Metal = 0.1: Si_Metal = 0.01: P_Metal = 0.004: S_Metal = 0.045: Fe_Metal = 0
Al_Metal = 0.02: Ni_Metal = 0.01: Cr_Metal = 0.09: Cu_Metal = 0.26

'' kg / ton Ac liq
HBI_AcL = (Masa_HBI * BaseAcero / AcLiquido)
ChatarraLigera_AcL = (Masa_ChatarraLigera * BaseAcero / AcLiquido)
Escarpa_AcL = (Masa_Escarpa * BaseAcero / AcLiquido)
HierroFundido_AcL = (Masa_HierroFundido * BaseAcero / AcLiquido)
ChatarraPesada_AcL = (Masa_ChatarraPesada * BaseAcero / AcLiquido)
Paca_AcL = (Masa_Paca * BaseAcero / AcLiquido)
PieLiquido_AcL = (Masa_PieLiquido * BaseAcero / AcLiquido)
HRD_AcL = (Masa_HRD * BaseAcero / AcLiquido)

'' total carga en Ton
Dim Tot_Carga As Single, Tot_Carga_enT As Single
Tot_Carga_enT = Masa_HBI + Masa_ChatarraLigera + Masa_Escarpa + Masa_HierroFundido + Masa_ChatarraPesada + Masa_Paca + Masa_PieLiquido + Masa_HRD
'' total en kg/TAL
Tot_Carga = HBI_AcL + ChatarraLigera_AcL + Escarpa_AcL + HierroFundido_AcL + ChatarraPesada_AcL + Paca_AcL + PieLiquido_AcL + HRD_AcL

'' kg / ton Ac liq
C_AcL = (C_Metal * BaseAcero / 100)
Mn_AcL = (Mn_Metal * BaseAcero / 100)
Si_AcL = (Si_Metal * BaseAcero / 100)
P_AcL = (P_Metal * BaseAcero / 100)
S_AcL = (S_Metal * BaseAcero / 100)
Fe_AcL = (Fe_Metal * BaseAcero / 100)
Al_AcL = (Al_Metal * BaseAcero / 100)
Ni_AcL = (Ni_Metal * BaseAcero / 100)
Cr_AcL = (Cr_Metal * BaseAcero / 100)
Cu_AcL = (Cu_Metal * BaseAcero / 100)

'' calculo de Hierro en el metal
If Fe_AcL <= 0 Then
    Fe_Metal = 100 - (C_AcL + Mn_AcL + Si_AcL + P_AcL + S_AcL + Al_AcL + Ni_AcL + Cr_AcL + Cu_AcL)
    Fe_AcL = (Fe_Metal * BaseAcero) / 100
End If

'' Balance de Metal Fundido *******************

''' CARBONO en %
Dim C_HBI As Single, C_ChatarraLigera As Single, C_Escarpa As Single, C_HierroFundido As Single, C_ChatarraPesada As Single, C_Paca As Single, C_PieLiquido As Single, C_HRD As Single
Dim C_Total As Single, C_TotalPociento As Single

C_HBI = (HBI_AcL * CargaMetalica("C", 0))
C_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("C", 1))
C_Escarpa = (Escarpa_AcL * CargaMetalica("C", 2))
C_HierroFundido = (HierroFundido_AcL * CargaMetalica("C", 3))
C_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("C", 4))
C_Paca = (Paca_AcL * CargaMetalica("C", 5)) / 100
C_PieLiquido = (PieLiquido_AcL * CargaMetalica("C", 6))
C_HRD = (HRD_AcL * CargaMetalica("C", 7))

'' total en kg/ton ac liq
C_Total = C_HBI + C_ChatarraLigera + C_Escarpa + C_HierroFundido + C_ChatarraPesada + C_Paca + C_PieLiquido + C_HRD
C_TotalPociento = (C_Total / Tot_Carga) * 100



''' MANGANESO en %
Dim Mn_HBI As Single, Mn_ChatarraLigera As Single, Mn_Escarpa As Single, Mn_HierroFundido As Single, Mn_ChatarraPesada As Single, Mn_Paca As Single, Mn_PieLiquido As Single, Mn_HRD As Single
Dim Mn_Total As Single, Mn_TotalPociento As Single

Mn_HBI = (HBI_AcL * CargaMetalica("Mn", 0))
Mn_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Mn", 1))
Mn_Escarpa = (Escarpa_AcL * CargaMetalica("Mn", 2))
Mn_HierroFundido = (HierroFundido_AcL * CargaMetalica("Mn", 3))
Mn_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Mn", 4))
Mn_Paca = (Paca_AcL * CargaMetalica("Mn", 5))
Mn_PieLiquido = (PieLiquido_AcL * CargaMetalica("Mn", 6))
Mn_HRD = (HRD_AcL * CargaMetalica("Mn", 7))
   
'' total en kg/ton ac liq
Mn_Total = Mn_HBI + Mn_ChatarraLigera + Mn_Escarpa + Mn_HierroFundido + Mn_ChatarraPesada + Mn_Paca + Mn_PieLiquido + Mn_HRD
Mn_TotalPociento = (Mn_Total / Tot_Carga) * 100



''' SILICIO en %
Dim Si_HBI As Single, Si_ChatarraLigera As Single, Si_Escarpa As Single, Si_HierroFundido As Single, Si_ChatarraPesada As Single, Si_Paca As Single, Si_PieLiquido As Single, Si_HRD As Single
Dim Si_Total As Single, Si_TotalPociento As Single

Si_HBI = (HBI_AcL * CargaMetalica("Si", 0))
Si_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Si", 1))
Si_Escarpa = (Escarpa_AcL * CargaMetalica("Si", 2))
Si_HierroFundido = (HierroFundido_AcL * CargaMetalica("Si", 3))
Si_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Si", 4))
Si_Paca = (Paca_AcL * CargaMetalica("Si", 5))
Si_PieLiquido = (PieLiquido_AcL * CargaMetalica("Si", 6))
Si_HRD = (HRD_AcL * CargaMetalica("Si", 7))

'' total en kg/ton ac liq
Si_Total = Si_HBI + Si_ChatarraLigera + Si_Escarpa + Si_HierroFundido + Si_ChatarraPesada + Si_Paca + Si_PieLiquido + Si_HRD
Si_TotalPociento = (Si_Total / Tot_Carga) * 100



''' FOSFORO en %
Dim P_HBI As Single, P_ChatarraLigera As Single, P_Escarpa As Single, P_HierroFundido As Single, P_ChatarraPesada As Single, P_Paca As Single, P_PieLiquido As Single, P_HRD As Single
Dim P_Total As Single, P_TotalPociento As Single

P_HBI = (HBI_AcL * CargaMetalica("P", 0))
P_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("P", 1))
P_Escarpa = (Escarpa_AcL * CargaMetalica("P", 2))
P_HierroFundido = (HierroFundido_AcL * CargaMetalica("P", 3))
P_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("P", 4))
P_Paca = (Paca_AcL * CargaMetalica("P", 5))
P_PieLiquido = (PieLiquido_AcL * CargaMetalica("P", 6))
P_HRD = (HRD_AcL * CargaMetalica("P", 7))

'' total en kg/ton ac liq
P_Total = P_HBI + P_ChatarraLigera + P_Escarpa + P_HierroFundido + P_ChatarraPesada + P_Paca + P_PieLiquido + P_HRD
P_TotalPociento = (P_Total / Tot_Carga) * 100




''' ASUFRE en %
Dim S_HBI As Single, S_ChatarraLigera As Single, S_Escarpa As Single, S_HierroFundido As Single, S_ChatarraPesada As Single, S_Paca As Single, S_PieLiquido As Single, S_HRD As Single
Dim S_Total As Single, S_TotalPociento As Single

S_HBI = (HBI_AcL * CargaMetalica("S", 0))
S_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("S", 1))
S_Escarpa = (Escarpa_AcL * CargaMetalica("S", 2))
S_HierroFundido = (HierroFundido_AcL * CargaMetalica("S", 3))
S_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("S", 4))
S_Paca = (Paca_AcL * CargaMetalica("S", 5))
S_PieLiquido = (PieLiquido_AcL * CargaMetalica("S", 6))
S_HRD = (HRD_AcL * CargaMetalica("S", 7))

'' total en kg/ton ac liq
S_Total = S_HBI + S_ChatarraLigera + S_Escarpa + S_HierroFundido + S_ChatarraPesada + S_Paca + S_PieLiquido + S_HRD
S_TotalPociento = (S_Total / Tot_Carga) * 100




''' HIERRO en  kg/ton ac liq
Dim Fe_HBI As Single, Fe_ChatarraLigera As Single, Fe_Escarpa As Single, Fe_HierroFundido As Single, Fe_ChatarraPesada As Single, Fe_Paca As Single, Fe_PieLiquido As Single, Fe_HRD As Single
Dim Fe_Total As Single, Fe_TotalPociento As Single

Fe_HBI = (HBI_AcL * CargaMetalica("FeT", 0))
Fe_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("FeT", 1))
Fe_Escarpa = (Escarpa_AcL * CargaMetalica("FeT", 2))
Fe_HierroFundido = (HierroFundido_AcL * CargaMetalica("FeT", 3))
Fe_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("FeT", 4))
Fe_Paca = (Paca_AcL * CargaMetalica("FeT", 5))
Fe_PieLiquido = (PieLiquido_AcL * CargaMetalica("FeT", 6))
Fe_HRD = (HRD_AcL * CargaMetalica("FeT", 7))

'' total en kg/ton ac liq
Fe_Total = Fe_HBI + Fe_ChatarraLigera + Fe_Escarpa + Fe_HierroFundido + Fe_ChatarraPesada + Fe_Paca + Fe_PieLiquido + Fe_HRD
Fe_TotalPociento = (Fe_Total / Tot_Carga) * 100




''' ALUMINIO en kg/ton ac liq
Dim Al_HBI As Single, Al_ChatarraLigera As Single, Al_Escarpa As Single, Al_HierroFundido As Single, Al_ChatarraPesada As Single, Al_Paca As Single, Al_PieLiquido As Single, Al_HRD As Single
Dim Al_Total As Single, Al_TotalPociento As Single

Al_HBI = (HBI_AcL * CargaMetalica("Al", 0))
Al_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Al", 1))
Al_Escarpa = (Escarpa_AcL * CargaMetalica("Al", 2))
Al_HierroFundido = (HierroFundido_AcL * CargaMetalica("Al", 3))
Al_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Al", 4))
Al_Paca = (Paca_AcL * CargaMetalica("Al", 5))
Al_PieLiquido = (PieLiquido_AcL * CargaMetalica("Al", 6))
Al_HRD = (HRD_AcL * CargaMetalica("Al", 7))

'' total en kg/ton ac liq
Al_Total = Al_HBI + Al_ChatarraLigera + Al_Escarpa + Al_HierroFundido + Al_ChatarraPesada + Al_Paca + Al_PieLiquido + Al_HRD
Al_TotalPociento = (Al_Total / Tot_Carga) * 100





''' NIQUE enkg/ton ac liq
Dim Ni_HBI As Single, Ni_ChatarraLigera As Single, Ni_Escarpa As Single, Ni_HierroFundido As Single, Ni_ChatarraPesada As Single, Ni_Paca As Single, Ni_PieLiquido As Single, Ni_HRD As Single
Dim Ni_Total As Single, Ni_TotalPociento As Single

Ni_HBI = (HBI_AcL * CargaMetalica("Ni", 0))
Ni_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Ni", 1))
Ni_Escarpa = (Escarpa_AcL * CargaMetalica("Ni", 2))
Ni_HierroFundido = (HierroFundido_AcL * CargaMetalica("Ni", 3))
Ni_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Ni", 4))
Ni_Paca = (Paca_AcL * CargaMetalica("Ni", 5))
Ni_PieLiquido = (PieLiquido_AcL * CargaMetalica("Ni", 6))
Ni_HRD = (HRD_AcL * CargaMetalica("Ni", 7))

'' total en kg/ton ac liq
Ni_Total = Ni_HBI + Ni_ChatarraLigera + Ni_Escarpa + Ni_HierroFundido + Ni_ChatarraPesada + Ni_Paca + Ni_PieLiquido + Ni_HRD
Ni_TotalPociento = (Ni_Total / Tot_Carga) * 100




''' CROMO en kg/ton ac liq
Dim Cr_HBI As Single, Cr_ChatarraLigera As Single, Cr_Escarpa As Single, Cr_HierroFundido As Single, Cr_ChatarraPesada As Single, Cr_Paca As Single, Cr_PieLiquido As Single, Cr_HRD As Single
Dim Cr_Total As Single, Cr_TotalPociento As Single

Cr_HBI = (HBI_AcL * CargaMetalica("Cr", 0))
Cr_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Cr", 1))
Cr_Escarpa = (Escarpa_AcL * CargaMetalica("Cr", 2))
Cr_HierroFundido = (HierroFundido_AcL * CargaMetalica("Cr", 3))
Cr_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Cr", 4))
Cr_Paca = (Paca_AcL * CargaMetalica("Cr", 5))
Cr_PieLiquido = (PieLiquido_AcL * CargaMetalica("Cr", 6))
Cr_HRD = (HRD_AcL * CargaMetalica("Cr", 7))

'' total en kg/ton ac liq
Cr_Total = Cr_HBI + Cr_ChatarraLigera + Cr_Escarpa + Cr_HierroFundido + Cr_ChatarraPesada + Cr_Paca + Cr_PieLiquido + Cr_HRD
Cr_TotalPociento = (Cr_Total / Tot_Carga) * 100




''' COBRE en kg/ton ac liq
Dim Cu_HBI As Single, Cu_ChatarraLigera As Single, Cu_Escarpa As Single, Cu_HierroFundido As Single, Cu_ChatarraPesada As Single, Cu_Paca As Single, Cu_PieLiquido As Single, Cu_HRD As Single
Dim Cu_Total As Single, Cu_TotalPociento As Single

Cu_HBI = (HBI_AcL * CargaMetalica("Cu", 0))
Cu_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Cu", 1))
Cu_Escarpa = (Escarpa_AcL * CargaMetalica("Cu", 2))
Cu_HierroFundido = (HierroFundido_AcL * CargaMetalica("Cu", 3))
Cu_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Cu", 4))
Cu_Paca = (Paca_AcL * CargaMetalica("Cu", 5))
Cu_PieLiquido = (PieLiquido_AcL * CargaMetalica("Cu", 6))
Cu_HRD = (HRD_AcL * CargaMetalica("Cu", 7))

'' total en kg/ton ac liq
Cu_Total = Cu_HBI + Cu_ChatarraLigera + Cu_Escarpa + Cu_HierroFundido + Cu_ChatarraPesada + Cu_Paca + Cu_PieLiquido + Cu_HRD
Cu_TotalPociento = (Cu_Total / Tot_Carga) * 100





'''  Calcular perdidas por elementos ***********************************
Dim C_Perdida As Single, Mn_Perdida As Single, Si_Perdida As Single, P_Perdida As Single, S_Perdida As Single, Fe_Perdida As Single
Dim Al_Perdida As Single, Ni_Perdida As Single, Cr_Perdida As Single, Cu_Perdida As Single
Dim Fe_Escoria As Single
Dim C_PorcPerdida As Single, Mn_PorcPerdida As Single, Si_PorcPerdida As Single, P_PorcPerdida As Single, S_PorcPerdida As Single, Fe_PorcPerdida As Single
Dim Al_PorcPerdida As Single, Ni_PorcPerdida As Single, Cr_PorcPerdida As Single, Cu_PorcPerdida As Single


'' en kg/TAL ''' tambien son los ELEMENTOS OXIDADOS******************************
C_Perdida = C_Total - C_AcL
Mn_Perdida = Mn_Total - Mn_AcL
Si_Perdida = Si_Total - Si_AcL
P_Perdida = P_Total - P_AcL
S_Perdida = S_Total - S_AcL
Fe_Perdida = Fe_Total - Fe_AcL
Fe_Escoria = Fe_Perdida * 0.15
Al_Perdida = Al_Total - Al_AcL
Ni_Perdida = Ni_Total - Ni_AcL
Cr_Perdida = Cr_Total - Cr_AcL
Cu_Perdida = Cu_Total - Cu_AcL

'' en %
C_PorcPerdida = (C_Perdida / C_Total) * 100
Mn_PorcPerdida = (Mn_Perdida / Mn_Total) * 100
Si_PorcPerdida = (Si_Perdida / Si_Total) * 100
P_PorcPerdida = (P_Perdida / P_Total) * 100
S_PorcPerdida = (S_Perdida / S_Total) * 100
Fe_PorcPerdida = (Fe_Perdida / Fe_Total) * 100
Al_PorcPerdida = (Al_Perdida / Al_Total) * 100
Ni_PorcPerdida = (Ni_Perdida / Ni_Total) * 100
Cr_PorcPerdida = (Cr_Perdida / Cr_Total) * 100
Cu_PorcPerdida = (Cu_Perdida / Cu_Total) * 100

''' CALCULO DEL HIERRO QUE VA A LA ESCORIA
''' ???????????????????????????????????????????????????????????????????????????????????????

'''POLVOS DE HIERRO A LOS GASES
Dim Fe_HBI_Polvo As Single, Fe_ChatarraLigera_Polvo As Single, Fe_Escarpa_Polvo As Single
Dim Fe_HierroFundido_Polvo As Single, Fe_ChatarraPesada_Polvo As Single, Fe_Paca_Polvo As Single, Fe_HRD_Polvo As Single

Fe_HBI_Polvo = (Fe_HBI * CargaMetalica("PolvoFe", 0))
Fe_ChatarraLigera_Polvo = (Fe_ChatarraLigera * CargaMetalica("PolvoFe", 1))
Fe_Escarpa_Polvo = (Fe_Escarpa * CargaMetalica("PolvoFe", 2))
Fe_HierroFundido_Polvo = (Fe_HierroFundido * CargaMetalica("PolvoFe", 3))
Fe_ChatarraPesada_Polvo = (Fe_ChatarraPesada * CargaMetalica("PolvoFe", 4))
Fe_Paca_Polvo = (Fe_Paca * CargaMetalica("PolvoFe", 5))
Fe_HRD_Polvo = (Fe_HRD * CargaMetalica("PolvoFe", 7))

'''total polvo
Dim Tot_Fe_Polvo As Single, Fe_Total2 As Single, Tot_Fe_PolvoPorciento As Single, Total_FeOxidoPolvo As Single
Dim Total_FeO_PolvoPorciento As Single, Total_FeOoxigenoPolvo As Single
'' fe total en polvo sin pie liquido
Tot_Fe_Polvo = Fe_HBI_Polvo + Fe_ChatarraLigera_Polvo + Fe_Escarpa_Polvo + Fe_HierroFundido_Polvo + Fe_ChatarraPesada_Polvo _
               + Fe_Paca_Polvo + Fe_HRD_Polvo
'' para calculo auxiliar
Fe_Total2 = Fe_HBI + Fe_ChatarraLigera + Fe_Escarpa + Fe_HierroFundido + Fe_ChatarraPesada + Fe_Paca + Fe_HRD
'' porciento de fe en polvos
Tot_Fe_PolvoPorciento = (Tot_Fe_Polvo / Fe_Total2) * 100
'' oxido de fe formado
Total_FeOxidoPolvo = Tot_Fe_Polvo * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
''' Porciento de oxido de herro en polvo
Total_FeO_PolvoPorciento = (Total_FeOxidoPolvo / Fe_Perdida) * 100
'' oxigeno requerido para el oxido de fe en polvo
Total_FeOoxigenoPolvo = Total_FeOxidoPolvo - Tot_Fe_Polvo



'''' OXIDOS FORMADOS que van a la escoria kg/TAL
Dim MnO As Single
MnO = Mn_Perdida * (OxidoRelacEsteq("MnO", 1) / OxidoRelacEsteq("MnO", 0))

Dim SiO2 As Single
SiO2 = Si_Perdida * (OxidoRelacEsteq("SiO2", 1) / OxidoRelacEsteq("SiO2", 0))

Dim P2O5 As Single
P2O5 = P_Perdida * (OxidoRelacEsteq("P2O5", 1) / (OxidoRelacEsteq("P2O5", 0) * 2))

Dim FeO As Single
FeO = Fe_Escoria * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))

Dim Al2O3 As Single
Al2O3 = Al_Perdida * (OxidoRelacEsteq("Al2O3", 1) / (OxidoRelacEsteq("Al2O3", 0) * 2))

Dim Cr2O3 As Single
Cr2O3 = Cr_Perdida * (OxidoRelacEsteq("Cr2O3", 1) / (OxidoRelacEsteq("Cr2O3", 0) * 2))




''' CALCULO DEL OXIGENO REQUERIDO
Dim MnO_OReq As Single
MnO_OReq = MnO - Mn_Perdida

Dim SiO2_OReq As Single
SiO2_OReq = SiO2 - Si_Perdida

Dim P2O5_OReq As Single
P2O5_OReq = P2O5 - P_Perdida

Dim FeO_OReq As Single
FeO_OReq = FeO - Fe_Escoria

Dim Al2O3_OReq As Single
Al2O3_OReq = Al2O3 - Al_Perdida

Dim Cr2O3_OReq As Single
Cr2O3_OReq = Cr2O3 - Cr_Perdida


'''' CALCULO DE LA COMPOSICION DE LA ESCORIA
'Dim Al2O3_Esc As Single, FeO_Esc As Single, S_Esc As Single, Cr2O3_Esc As Single
'Dim CaO_Esc As Single, MgO_Esc As Single, C_Esc As Single

MnO_Esc = MnO + OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)
              
SiO2_Esc = SiO2 + OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

P2O5_Esc = P2O5 + OxidosDeCargas("P2O5", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

CaO_Esc = OxidosDeCargas("CaO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

MgO_Esc = OxidosDeCargas("MgO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

Al2O3_Esc = Al2O3 + OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

Cr2O3_Esc = Cr2O3 + OxidosDeCargas("Cr2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

FeO_Esc = FeO + OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

S_Esc = S_Perdida

Otros_Esc = OxidosDeCargas("Otros", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)


'''DETERMINACION DE PERDIDAS POR IGNICION ( CALCINACION )
Dim HBI_Ignicion As Single, ChatarraLigera_Ignicion As Single, Escarpa_Ignicion As Single
Dim HierroFundido_Ignicion As Single, ChatarraPesada_Ignicion As Single, Paca_Ignicion As Single, HRD_Ignicion As Single
Dim Cal_Ignicion As Single, Dolomita_Ignicion As Single, Carbon_Ignicion As Single
Dim Ignicion_Total As Single

HBI_Ignicion = (HBI_AcL * CargaMetalica("P.Ignicion", 0))
ChatarraLigera_Ignicion = (ChatarraLigera_AcL * CargaMetalica("P.Ignicion", 1))
Escarpa_Ignicion = (Escarpa_AcL * CargaMetalica("P.Ignicion", 2))
HierroFundido_Ignicion = (HierroFundido_AcL * CargaMetalica("P.Ignicion", 3))
ChatarraPesada_Ignicion = (ChatarraPesada_AcL * CargaMetalica("P.Ignicion", 4))
Paca_Ignicion = (Paca_AcL * CargaMetalica("P.Ignicion", 5))
HRD_Ignicion = (HRD_AcL * CargaMetalica("P.Ignicion", 7))

Cal_Ignicion = (Peso_Cal * CargaRefracFundente("P.Ignicion", 2))
Dolomita_Ignicion = (Peso_Dolomita * CargaRefracFundente("P.Ignicion", 1))
Carbon_Ignicion = (Peso_Carbon * CargaRefracFundente("P.Ignicion", 0))

'' total
Ignicion_Total = HBI_Ignicion + ChatarraLigera_Ignicion + Escarpa_Ignicion + HierroFundido_Ignicion _
                 + ChatarraPesada_Ignicion + Paca_Ignicion + HRD_Ignicion + Cal_Ignicion + Dolomita_Ignicion + Carbon_Ignicion

''' PONDERACION PARA LA COMBUSTION DEL CARBONO CON RESPECTO A LA POST COMBUSTION
Dim A As Single, B As Single
'' de la tabla de las energias de reacciones quim
A = EnergReacQuimicas(9, 1): B = EnergReacQuimicas(10, 1)

''' asumir composicion de gases si no se da
If CO <= 0 Then
   CO = 85 ''%
End If
If CO2 <= 0 Then
   CO2 = 15 ''%
End If

''' calculo de ponderado para la post-combustion
Dim PComb_Ponderado_Carbono As Single
PComb_Ponderado_Carbono = (CO * A) / 100 + (CO2 * B) / 100
    
If Masa_HRD >= 0 Then
    ''' PONDERACION PARA LA COMBUSTION DE LA cementita CON RESPECTO A LA POST COMBUSTION
    '' de la tabla de las energias de reacciones quim
    A = EnergReacQuimicas(12, 1): B = EnergReacQuimicas(13, 1)
    ''' calculo de ponderado para la post-combustion
    Dim PComb_Ponderado_Cementita As Single
    PComb_Ponderado_Cementita = (CO * A) / 100 + (CO2 * B) / 100
End If


''' PONDERACION PARA la reduccion del Fe con respecto a la post combustion
Dim PesoFeO_Ponderado  As Single, PesoFe2O3_Ponderado As Single
''FeO
If Masa_HRD >= 0 Then

    A = EnergReacQuimicas(3, 1): B = EnergReacQuimicas(4, 1)
    PesoFeO_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(1, 1): B = EnergReacQuimicas(2, 1)
    PesoFe2O3_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
Else

    A = EnergReacQuimicas(7, 1): B = EnergReacQuimicas(8, 1)
    PesoFeO_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(5, 1): B = EnergReacQuimicas(6, 1)
    PesoFe2O3_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
End If

''=======================CALCULO DE LAS ENERGIAS=================================
Dim EnergiaFeO_Ponderado As Single, EnergiaFe2O3_Ponderado As Single
Dim EnergiaFeO_Ponderado2 As Single, EnergiaFe2O3_Ponderado2 As Single

'' por ponderacion
If Masa_HRD >= 0 Then

    A = EnergReacQuimicas(3, 4): B = EnergReacQuimicas(4, 4)
    EnergiaFeO_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(1, 4): B = EnergReacQuimicas(2, 4)
    EnergiaFe2O3_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(5, 4): B = EnergReacQuimicas(6, 4)
    EnergiaFe2O3_Ponderado2 = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(7, 4): B = EnergReacQuimicas(8, 4)
    EnergiaFeO_Ponderado2 = (CO * A) / 100 + (CO2 * B) / 100
    
Else

    A = EnergReacQuimicas(5, 4): B = EnergReacQuimicas(6, 4)
    EnergiaFe2O3_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
    A = EnergReacQuimicas(7, 4): B = EnergReacQuimicas(8, 4)
    EnergiaFeO_Ponderado = (CO * A) / 100 + (CO2 * B) / 100
    
End If


''''' CANTIDAD DE OXIDO DE HIERRO CARGADO, CARBONO PARA SU REDUCCION Y CONTENIDO DE OXIGEN
''' CALCULO DE OXIDO DE HIERRO EN LA CARGA   Fe++
Dim FeO_Carga_HBI As Single, FeO_Carga_ChatarraLigera As Single, FeO_Carga_Escarpa As Single, FeO_Carga_HierroFundido As Single
Dim FeO_Carga_ChatarraPesada As Single, FeO_Carga_Paca As Single, FeO_Carga_HRD As Single, FeO_Carga_Cal As Single
Dim FeO_Carga_Dolomita As Single, FeO_Carga_Carbon As Single

Dim Fe2O3_Carga_HBI As Single, Fe2O3_Carga_ChatarraLigera As Single, Fe2O3_Carga_Escarpa As Single, Fe2O3_Carga_HierroFundido As Single
Dim Fe2O3_Carga_ChatarraPesada As Single, Fe2O3_Carga_Paca As Single, Fe2O3_Carga_HRD As Single, Fe2O3_Carga_Cal As Single
Dim Fe2O3_Carga_Dolomita As Single, Fe2O3_Carga_Carbon As Single

''FeO
FeO_Carga_HBI = (HBI_AcL * CargaMetalica("Fe++", 0) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Fe++", 1) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_Escarpa = (Escarpa_AcL * CargaMetalica("Fe++", 2) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_HierroFundido = (HierroFundido_AcL * CargaMetalica("Fe++", 3) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Fe++", 4) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_Paca = (Paca_AcL * CargaMetalica("Fe++", 5) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_HRD = (HRD_AcL * CargaMetalica("Fe++", 7) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))

FeO_Carga_Cal = (Peso_Cal * CargaRefracFundente("Fe++", 2) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_Dolomita = (Peso_Dolomita * CargaRefracFundente("Fe++", 1) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))
FeO_Carga_Carbon = (Peso_Carbon * CargaRefracFundente("Fe++", 0) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0)))

''Fe2O3
Fe2O3_Carga_HBI = (HBI_AcL * CargaMetalica("Fe2O3", 0) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Fe2O3", 1) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_Escarpa = (Escarpa_AcL * CargaMetalica("Fe2O3", 2) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_HierroFundido = (HierroFundido_AcL * CargaMetalica("Fe2O3", 3) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Fe2O3", 4) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_Paca = (Paca_AcL * CargaMetalica("Fe2O3", 5) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_HRD = (HRD_AcL * CargaMetalica("Fe2O3", 7) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))

Fe2O3_Carga_Cal = (Peso_Cal * CargaRefracFundente("Fe2O3", 2) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_Dolomita = (Peso_Dolomita * CargaRefracFundente("Fe2O3", 1) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("Fe2O3", 0)))
Fe2O3_Carga_Carbon = (Peso_Carbon * CargaRefracFundente("Fe2O3", 0) * (OxidoRelacEsteq("Fe2O3", 1) / OxidoRelacEsteq("Fe2O3", 0)))

''' CALCULO DE CARBONO PARA LA REDUCCION DE HIERRO
Dim CFeO_Reducc_HBI As Single, CFeO_Reducc_ChatarraLigera As Single, CFeO_Reducc_Escarpa As Single, CFeO_Reducc_HierroFundido As Single
Dim CFeO_Reducc_ChatarraPesada As Single, CFeO_Reducc_Paca As Single, CFeO_Reducc_HRD As Single, CFeO_Reducc_Cal As Single
Dim CFeO_Reducc_Dolomita As Single, CFeO_Reducc_Carbon As Single

Dim CFe2O3_Reducc_HBI As Single, CFe2O3_Reducc_ChatarraLigera As Single, CFe2O3_Reducc_Escarpa As Single, CFe2O3_Reducc_HierroFundido As Single
Dim CFe2O3_Reducc_ChatarraPesada As Single, CFe2O3_Reducc_Paca As Single, CFe2O3_Reducc_HRD As Single, CFe2O3_Reducc_Cal As Single
Dim CFe2O3_Reducc_Dolomita As Single, CFe2O3_Reducc_Carbon As Single

Dim C_Reducc_HBI As Single, C_Reducc_ChatarraLigera As Single, C_Reducc_Escarpa As Single, C_Reducc_HierroFundido As Single
Dim C_Reducc_ChatarraPesada As Single, C_Reducc_Paca As Single, C_Reducc_HRD As Single, C_Reducc_Cal As Single
Dim C_Reducc_Dolomita As Single, C_Reducc_Carbon As Single

'' FeO
CFeO_Reducc_HBI = FeO_Carga_HBI / PesoFeO_Ponderado
CFeO_Reducc_ChatarraLigera = FeO_Carga_ChatarraLigera / PesoFeO_Ponderado
CFeO_Reducc_Escarpa = FeO_Carga_Escarpa / PesoFeO_Ponderado
CFeO_Reducc_HierroFundido = FeO_Carga_HierroFundido / PesoFeO_Ponderado
CFeO_Reducc_ChatarraPesada = FeO_Carga_ChatarraPesada / PesoFeO_Ponderado
CFeO_Reducc_Paca = FeO_Carga_Paca / PesoFeO_Ponderado
CFeO_Reducc_HRD = FeO_Carga_HRD / PesoFeO_Ponderado

CFeO_Reducc_Cal = FeO_Carga_Cal / PesoFeO_Ponderado
CFeO_Reducc_Dolomita = FeO_Carga_Dolomita / PesoFeO_Ponderado
CFeO_Reducc_Carbon = FeO_Carga_Carbon / PesoFeO_Ponderado
''Fe2O3
CFe2O3_Reducc_HBI = Fe2O3_Carga_HBI / PesoFe2O3_Ponderado
CFe2O3_Reducc_ChatarraLigera = Fe2O3_Carga_ChatarraLigera / PesoFe2O3_Ponderado
CFe2O3_Reducc_Escarpa = Fe2O3_Carga_Escarpa / PesoFe2O3_Ponderado
CFe2O3_Reducc_HierroFundido = Fe2O3_Carga_HierroFundido / PesoFe2O3_Ponderado
CFe2O3_Reducc_ChatarraPesada = Fe2O3_Carga_ChatarraPesada / PesoFe2O3_Ponderado
CFe2O3_Reducc_Paca = Fe2O3_Carga_Paca / PesoFe2O3_Ponderado
CFe2O3_Reducc_HRD = Fe2O3_Carga_HRD / PesoFe2O3_Ponderado

CFe2O3_Reducc_Cal = Fe2O3_Carga_Cal / PesoFe2O3_Ponderado
CFe2O3_Reducc_Dolomita = Fe2O3_Carga_Dolomita / PesoFe2O3_Ponderado
CFe2O3_Reducc_Carbon = Fe2O3_Carga_Carbon / PesoFe2O3_Ponderado
'Total
C_Reducc_HBI = CFeO_Reducc_HBI + CFe2O3_Reducc_HBI
C_Reducc_ChatarraLigera = CFeO_Reducc_ChatarraLigera + CFe2O3_Reducc_ChatarraLigera
C_Reducc_Escarpa = CFeO_Reducc_Escarpa + CFe2O3_Reducc_Escarpa
C_Reducc_HierroFundido = CFeO_Reducc_HierroFundido + CFe2O3_Reducc_HierroFundido
C_Reducc_ChatarraPesada = CFeO_Reducc_ChatarraPesada + CFe2O3_Reducc_ChatarraPesada
C_Reducc_Paca = CFeO_Reducc_Paca + CFe2O3_Reducc_Paca
C_Reducc_HRD = CFeO_Reducc_HRD + CFe2O3_Reducc_HRD

C_Reducc_Cal = CFeO_Reducc_Cal + CFe2O3_Reducc_Cal
C_Reducc_Dolomita = CFeO_Reducc_Dolomita + CFe2O3_Reducc_Dolomita
C_Reducc_Carbon = CFeO_Reducc_Carbon + CFe2O3_Reducc_Carbon

''' CALCULO DEL CONTENIDO DE OXIGENO PARA LA REDUCCION DE HIERRO  Fe++
Dim OxFeO_Reducc_HBI As Single, OxFeO_Reducc_ChatarraLigera As Single, OxFeO_Reducc_Escarpa As Single, OxFeO_Reducc_HierroFundido As Single
Dim OxFeO_Reducc_ChatarraPesada As Single, OxFeO_Reducc_Paca As Single, OxFeO_Reducc_HRD As Single, OxFeO_Reducc_Cal As Single
Dim OxFeO_Reducc_Dolomita As Single, OxFeO_Reducc_Carbon As Single

Dim OxFe2O3_Reducc_HBI As Single, OxFe2O3_Reducc_ChatarraLigera As Single, OxFe2O3_Reducc_Escarpa As Single, OxFe2O3_Reducc_HierroFundido As Single
Dim OxFe2O3_Reducc_ChatarraPesada As Single, OxFe2O3_Reducc_Paca As Single, OxFe2O3_Reducc_HRD As Single, OxFe2O3_Reducc_Cal As Single
Dim OxFe2O3_Reducc_Dolomita As Single, OxFe2O3_Reducc_Carbon As Single

Dim Ox_Reducc_HBI As Single, Ox_Reducc_ChatarraLigera As Single, Ox_Reducc_Escarpa As Single, Ox_Reducc_HierroFundido As Single
Dim Ox_Reducc_ChatarraPesada As Single, Ox_Reducc_Paca As Single, Ox_Reducc_HRD As Single, Ox_Reducc_Cal As Single
Dim Ox_Reducc_Dolomita As Single, Ox_Reducc_Carbon As Single

'FeO
OxFeO_Reducc_HBI = (FeO_Carga_HBI * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_ChatarraLigera = (FeO_Carga_ChatarraLigera * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_Escarpa = (FeO_Carga_Escarpa * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_HierroFundido = (FeO_Carga_HierroFundido * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_ChatarraPesada = (FeO_Carga_ChatarraPesada * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_Paca = (FeO_Carga_Paca * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_HRD = (FeO_Carga_HRD * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)

OxFeO_Reducc_Cal = (FeO_Carga_Cal * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_Dolomita = (FeO_Carga_Dolomita * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
OxFeO_Reducc_Carbon = (FeO_Carga_Carbon * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("FeO", 1)
''Fe2O3
OxFe2O3_Reducc_HBI = (Fe2O3_Carga_HBI * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_ChatarraLigera = (Fe2O3_Carga_ChatarraLigera * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_Escarpa = (Fe2O3_Carga_Escarpa * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_HierroFundido = (Fe2O3_Carga_HierroFundido * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_ChatarraPesada = (Fe2O3_Carga_ChatarraPesada * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_Paca = (Fe2O3_Carga_Paca * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_HRD = (Fe2O3_Carga_HRD * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)

OxFe2O3_Reducc_Cal = (Fe2O3_Carga_Cal * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_Dolomita = (Fe2O3_Carga_Dolomita * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)
OxFe2O3_Reducc_Carbon = (Fe2O3_Carga_Carbon * OxidoRelacEsteq("O", 0)) / OxidoRelacEsteq("Fe2O3", 1)

'Total
Ox_Reducc_HBI = OxFeO_Reducc_HBI + OxFe2O3_Reducc_HBI
Ox_Reducc_ChatarraLigera = OxFeO_Reducc_ChatarraLigera + OxFe2O3_Reducc_ChatarraLigera
Ox_Reducc_Escarpa = OxFeO_Reducc_Escarpa + OxFe2O3_Reducc_Escarpa
Ox_Reducc_HierroFundido = OxFeO_Reducc_HierroFundido + OxFe2O3_Reducc_HierroFundido
Ox_Reducc_ChatarraPesada = OxFeO_Reducc_ChatarraPesada + OxFe2O3_Reducc_ChatarraPesada
Ox_Reducc_Paca = OxFeO_Reducc_Paca + OxFe2O3_Reducc_Paca
Ox_Reducc_HRD = OxFeO_Reducc_HRD + OxFe2O3_Reducc_HRD

Ox_Reducc_Cal = OxFeO_Reducc_Cal + OxFe2O3_Reducc_Cal
Ox_Reducc_Dolomita = OxFeO_Reducc_Dolomita + OxFe2O3_Reducc_Dolomita
Ox_Reducc_Carbon = OxFeO_Reducc_Carbon + OxFe2O3_Reducc_Carbon



''' CALCULO DE LA COMPOSICION QUIMICA DE LOS GASES ********************************
''' relacion especifica de pesos
Dim RelEsp_C_CO As Single, RelEsp_C_CO2 As Single

RelEsp_C_CO = (CO * (OxidoRelacEsteq("CO", 1) / OxidoRelacEsteq("CO", 0))) / 100
RelEsp_C_CO2 = (CO2 * (OxidoRelacEsteq("CO2", 1) / OxidoRelacEsteq("CO2", 0))) / 100

''' determinacion de la cantidad de CO y CO2
Dim Cant_CO As Single, Cant_CO2 As Single, Cant_CO_Electrodo As Single, Cant_CO2_Electrodo As Single
'Carbono
Cant_CO = C_Perdida * RelEsp_C_CO ''kg/TAL
Cant_CO2 = C_Perdida * RelEsp_C_CO2 ''kg/TAL
'Electrodos
Cant_CO_Electrodo = IndiceConsumo("PuntaElectrodo") * RelEsp_C_CO ''kg/TAL
Cant_CO2_Electrodo = IndiceConsumo("PuntaElectrodo") * RelEsp_C_CO2 ''kg/TAL


''' OXIDO FORMADO EN EL CARBONO **********************
Dim Ox_form_C As Single
Ox_form_C = (((C_Perdida * CO) / 100) * (OxidoRelacEsteq("CO", 1) / OxidoRelacEsteq("CO", 0))) + (((C_Perdida * CO2) / 100) * (OxidoRelacEsteq("CO2", 1) / OxidoRelacEsteq("CO2", 0)))

''' OXIGENO REQUERIDO DEL CARBONO **********************
Dim Ox_Req_C As Single
Ox_Req_C = Ox_form_C - C_Perdida

''' OXIGENO DEL CARBON --------------------------
Dim Ox_Reg_Carbon As Single
Ox_Reg_Carbon = (((Peso_Carbon * CO) / 100) * (OxidoRelacEsteq("O", 0) / OxidoRelacEsteq("C", 0))) + (((Peso_Carbon * CO2) / 100) * ((OxidoRelacEsteq("O", 0) * 2) / OxidoRelacEsteq("C", 0)))

''' OXIGENO DE  ELECTRODO --------------------------
Dim Ox_Reg_Electrodo As Single
Ox_Reg_Electrodo = (((IndiceConsumo("PuntaElectrodo") * CO) / 100) * (OxidoRelacEsteq("O", 0) / OxidoRelacEsteq("C", 0))) + (((IndiceConsumo("PuntaElectrodo") * CO2) / 100) * ((OxidoRelacEsteq("O", 0) * 2) / OxidoRelacEsteq("C", 0)))

''' ANALISIS DE OXIGENO PARA DESCARBURIZACION  ***********************
'' oxigeno total para descarburizacion
Dim Ox_Descarburacion As Single
Ox_Descarburacion = Ox_Req_C + Ox_Reg_Carbon '+ Ox_Reg_Electrodo

' oxigeno en la escoria
Dim Ox_Escoria As Single
Ox_Escoria = FeO_Esc * (OxidoRelacEsteq("O", 0) / OxidoRelacEsteq("FeO", 1))

' oxigeno del oxido de hierro cargado
Dim Ox_FeOFe2O3_Cargado As Single
Dim Sum_Ox_FeO As Single, Sum_Ox_Fe2O3 As Single
Sum_Ox_FeO = OxFeO_Reducc_HBI + OxFeO_Reducc_ChatarraLigera + OxFeO_Reducc_Escarpa + OxFeO_Reducc_HierroFundido + OxFeO_Reducc_ChatarraPesada _
             + OxFeO_Reducc_Paca + OxFeO_Reducc_HRD + OxFeO_Reducc_Cal + OxFeO_Reducc_Dolomita + OxFeO_Reducc_Carbon
             
Sum_Ox_Fe2O3 = OxFe2O3_Reducc_HBI + OxFe2O3_Reducc_ChatarraLigera + OxFe2O3_Reducc_Escarpa + OxFe2O3_Reducc_HierroFundido + OxFe2O3_Reducc_ChatarraPesada _
             + OxFe2O3_Reducc_Paca + OxFe2O3_Reducc_HRD + OxFe2O3_Reducc_Cal + OxFe2O3_Reducc_Dolomita + OxFe2O3_Reducc_Carbon
             
Ox_FeOFe2O3_Cargado = Ox_Reducc_HBI + Ox_Reducc_ChatarraLigera + Ox_Reducc_Escarpa + Ox_Reducc_HierroFundido + Ox_Reducc_ChatarraPesada _
                     + Ox_Reducc_Paca + Ox_Reducc_HRD + Ox_Reducc_Cal + Ox_Reducc_Dolomita + Ox_Reducc_Carbon
             
''' oxigeno gaseoso para descaburizacion
Dim Ox_Gas_Descarb As Single
Ox_Gas_Descarb = ((Ox_Descarburacion + Ox_Escoria) - Ox_FeOFe2O3_Cargado) / (Oxigeno_EficInyectado / 100)


''' ANALISIS DE OXIGENO PARA LA OXIDACION DE ELEMENTOS  ***********************
'' Oxigeno de elementos
Dim Ox_Elementos As Single
Ox_Elementos = MnO_OReq + SiO2_OReq + P2O5_OReq + FeO_OReq + Al2O3_OReq + Cr2O3_OReq + Ox_Reg_Electrodo


''' AIRE DE INFILTRACION
Dim AInfil_Aire As Single, AInfil_Nitrogeno As Single, AInfil_Oxigeno As Single
AInfil_Aire = Dens_Aire * Vol_Aire
AInfil_Nitrogeno = Dens_Nitrogeno * Vol_Nitrogeno
AInfil_Oxigeno = Dens_Oxigeno * Vol_Oxigeno

'' ' OXIGENO GASEOSO PARA OXIDACION DE ELEMENTOS
Dim Ox_Gas_Ox As Single
Ox_Gas_Ox = (Ox_Elementos - (Ox_Escoria + AInfil_Oxigeno)) / (Oxigeno_EficInyectado / 100)

'' ' OXIGENO GASEOSO TOTAL INYECTADO
Dim Ox_Gas_Total As Single
Ox_Gas_Total = Ox_Gas_Descarb + Ox_Gas_Ox

'' OXIGENO LIBRE
Dim Ox_Libre As Single
Ox_Libre = Ox_Gas_Total * ((100 - Oxigeno_EficInyectado) / 100)





''******************************* EJECUCION DE LOS BALANCES DE OXIGENO *******************************
    Entradas = Sum_Ox_FeO + Sum_Ox_Fe2O3 + AInfil_Oxigeno + Ox_Gas_Total
    Salidas = Ox_Elementos + Ox_Req_C + Ox_Reg_Carbon + Ox_Libre
    If Entradas <> Salidas Then MsgBox ("Balance de Oxigeno incorrecto")



''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE CALCIO *******************************
Dim CaO_ref As Single, CaO_Carga As Single 'CaO_AcLiq As Single, CaO_Cal As Single, CaO_CalReal As Single
    '' calculo del oxido de silicio de refractario
    CaO_ref = (CargaRefracFundente("CaO", 3) * IndiceConsumo("LadrilloPared")) _
               + (CargaRefracFundente("CaO", 4) * IndiceConsumo("CentroBobeda")) _
               + (CargaRefracFundente("CaO", 6) * IndiceConsumo("Proyectable")) _
               + (CargaRefracFundente("CaO", 5) * IndiceConsumo("Apisonable"))
               
    '' calculo del Oxido de calcio de carga metalica
    CaO_Carga = CaO_Esc - ((CargaRefracFundente("CaO", 2) * Peso_Cal) _
                          + (CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                          + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
                          + CaO_ref)

    '' comprobar balance calcio
    Entradas = CaO_Carga + ((CargaRefracFundente("CaO", 2) * Peso_Cal) _
                          + (CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                          + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
                          + CaO_ref)
    Salidas = CaO_Esc
    If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Calcio incorrecto")
    '' no hay CaO en la Carga metalica
    If CaO_Carga < 0 Then CaO_Carga = 0



    ''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE SILICIO *******************************
Dim SiO2_Carga As Single

    ' conversion del elemento de carga a oxido
    Dim Si_ConvSiO2 As Single
    Si_ConvSiO2 = Si_Total * (OxidoRelacEsteq("SiO2", 1) / OxidoRelacEsteq("SiO2", 0))
    
    ' carga
    SiO2_Carga = OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)
    
    ' conversion del silicio del acero a oxido
    Dim SiO2_AcLiq As Single
    SiO2_AcLiq = Si_AcL * (OxidoRelacEsteq("SiO2", 1) / OxidoRelacEsteq("SiO2", 0))
    
    ''''''''''''''''''''''''''''''''''''''''''''''
    
    Entradas = Si_ConvSiO2 + SiO2_Carga
    Salidas = SiO2_Esc + SiO2_AcLiq
    If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Silicio incorrecto")


    
    ''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE MAGNESIO *******************************
    Dim MgO_Carga As Single
    
    ' carga
    MgO_Carga = MgO_Esc
    
    Entradas = MgO_Carga
    Salidas = MgO_Esc
    If Entradas <> Salidas Then MsgBox ("Balance de Oxido de MAGNESIO incorrecto")





    ''******************************* EJECUCION DE LOS BALANCES DEL ALUMINA *******************************
    Dim Al2O3_Carga As Single
    
    'carga
    Al2O3_Carga = Al2O3 + OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)
    
    ' conversion del elemento de carga a oxido
    Dim Al_ConvAl2O3 As Single
    Al_ConvAl2O3 = Al_Total * (OxidoRelacEsteq("Al2O3", 1) / (OxidoRelacEsteq("Al2O3", 0) * 2))
    
    ' conversion del elemento del acero a oxido
    Dim Al2O3_AcLiq As Single
    Al2O3_AcLiq = Al_AcL * (OxidoRelacEsteq("Al2O3", 1) / (OxidoRelacEsteq("Al2O3", 0) * 2))
    
    Entradas = Al_ConvAl2O3 + Al2O3_Carga
    Salidas = Al2O3_Esc + Al2O3_AcLiq
    If Entradas <> Salidas Then MsgBox ("Balance de Alumina incorrecto")

    
    
    
    
    ''******************************* EJECUCION DE LOS BALANCES DEL OXIDO DE Mn *******************************
Dim MnO_Carga As Single
    
    ' carga
    MnO_Carga = OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)
    
    ' conversion del elemento de carga a oxido
    Dim Mn_ConvMnO As Single
    Mn_ConvMnO = Mn_Total * (OxidoRelacEsteq("MnO", 1) / OxidoRelacEsteq("MnO", 0))
    
    ' conversion del elemento del acero a oxido
    Dim MnO_AcLiq As Single
    MnO_AcLiq = Mn_AcL * (OxidoRelacEsteq("MnO", 1) / OxidoRelacEsteq("MnO", 0))
    
    Entradas = Mn_ConvMnO + MnO_Carga
    Salidas = MnO_Esc + MnO_AcLiq
    If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Manganeso incorrecto")

    
    
    
    
    ''******************************* EJECUCION DE LOS BALANCES DEL OXIDO DE Fe *******************************
    Dim FeO_Carga As Single
    
    ' carga
    FeO_Carga = OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

    ' conversion del elemento de carga a oxido
    Dim Fe_ConvFeO As Single
    Fe_ConvFeO = Fe_Total * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
    
    ' conversion del elemento del acero a oxido
    Dim FeO_AcLiq As Single
    FeO_AcLiq = Fe_AcL * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
    
    Entradas = Fe_ConvFeO + FeO_Carga
    Salidas = FeO_Esc + FeO_AcLiq + Total_FeOxidoPolvo
    If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Hierro incorrecto")










    
    
    
    
    
    
    

MnO_Esc = MnO + OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)
              
SiO2_Esc = SiO2 + OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

P2O5_Esc = P2O5 + OxidosDeCargas("P2O5", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

CaO_Esc = OxidosDeCargas("CaO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

MgO_Esc = OxidosDeCargas("MgO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

Al2O3_Esc = OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

Cr2O3_Esc = Cr2O3 + OxidosDeCargas("Cr2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

FeO_Esc = FeO + OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL, ChatarraPesada_AcL, Paca_AcL, HRD_AcL)

End Sub


''' funcion para calcular la carga en funcion de la composicion quinica del metal y la escoria
Public Sub Carga_Segun_Escoria_Metal()
Dim Entradas As Single, Salida As Single

    '' ELEMENTOS DE ENTRADA ''''---------------------------------------------------
    SiO2_Esc = 19.9: Si_Metal = 0.01
    CaO_Esc = 33
    MgO_Esc = 6.8
    Al2O3_Esc = 7.3: Al_Metal = 0
    MnO_Esc = 5.7: Mn_Metal = 0.1
    FeO_Esc = 20.58 ': Fe_Metal = 99.796
    P2O5_Esc = 0: P_Metal = 0.02
    S_Esc = 0: S_Metal = 0.05
    Cr2O3_Esc = 0: Cr_Metal = 0.09 ' fijo
    C_Esc = 0: C_Metal = 0.09
    
    Fe_Metal = 100 - (Si_Metal + Al_Metal + Mn_Metal + P_Metal + S_Metal + Cr_Metal + C_Metal)
    
    ''*************balance del oxido de silicio
    'Si_Metal = 0.01: SiO2_Esc = 19.9
    Dim SiO2_ox As Single, SiO2_ref As Single, SiO2_Carga As Single, SiO2_AcLiq As Single, SiO2_Ox_Carga As Single
    '' calculo del oxido de silicio de oxidacion ''' el oxido de la escoria se lleva a kg / ton Ac liq '' como es base 100 kg queda igual (*100/100)
    ''SiO2_ox = SiO2_Esc * (OxidoRelacEsteq("SiO2", 0) / OxidoRelacEsteq("SiO2", 1)) ''el peso atomico es el del elemento Si'' se busca asi en la base de datos
    '' calculo del oxido de silicio de refractario
    SiO2_ref = (CargaRefracFundente("SiO2", 3) * IndiceConsumo("LadrilloPared")) _
               + (CargaRefracFundente("SiO2", 4) * IndiceConsumo("CentroBobeda")) _
               + (CargaRefracFundente("SiO2", 6) * IndiceConsumo("Proyectable")) _
               + (CargaRefracFundente("SiO2", 5) * IndiceConsumo("Apisonable"))
    '' conversion del Si del Ac liquido a oxido de silicio
    SiO2_AcLiq = (Si_Metal * BaseAcero / 100) * (OxidoRelacEsteq("SiO2", 1) / OxidoRelacEsteq("SiO2", 0))
    
    '' oxido de silicio que hay en la carga ( el 0.5 es estimado )
    SiO2_Ox_Carga = SiO2_Esc * 0.5
    
    '' calculo del Oxido de silicio de carga
    SiO2_Carga = SiO2_Esc + SiO2_AcLiq - (SiO2_Ox_Carga + (CargaRefracFundente("SiO2", 2) * Peso_Cal) _
                                                  + (CargaRefracFundente("SiO2", 1) * Peso_Dolomita) _
                                                  + (CargaRefracFundente("SiO2", 7) * IndiceConsumo("CenizaElectrodo")) _
                                                  + SiO2_ref)
    '' comprobar balance silicio
    Entradas = SiO2_ref + SiO2_Carga + SiO2_Ox_Carga + (CargaRefracFundente("SiO2", 2) * Peso_Cal) _
                                               + (CargaRefracFundente("SiO2", 1) * Peso_Dolomita) _
                                               + (CargaRefracFundente("SiO2", 7) * IndiceConsumo("CenizaElectrodo"))
    Salida = SiO2_AcLiq + SiO2_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Silicio incorrecto")
    
    '' calculo del de silicio de carga
    Dim Si_Carga As Single
    Si_Carga = SiO2_Carga * (OxidoRelacEsteq("SiO2", 0) / OxidoRelacEsteq("SiO2", 1)) '' kg / tonAc liq
    
    '' porciento de silicio en carga
    Dim Si_CargaPorciento As Single
    Si_CargaPorciento = (Si_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim Si_Perdida As Single
    Si_Perdida = Si_Carga - ((Si_Metal * BaseAcero) / 100) '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim Si_PerdidaPorciento As Single
    Si_PerdidaPorciento = (Si_Perdida / Si_Carga) * 100 '' %
    
    
    
    
    
    ''*************balance del oxido de Calcio *****************************************
    'CaO_Esc = 31.6
    Dim CaO_ref As Single, CaO_Carga As Single, CaO_AcLiq As Single, CaO_Cal As Single, CaO_CalReal As Single
    
    '' calculo del oxido de silicio de refractario
    CaO_ref = (CargaRefracFundente("CaO", 3) * IndiceConsumo("LadrilloPared")) _
               + (CargaRefracFundente("CaO", 4) * IndiceConsumo("CentroBobeda")) _
               + (CargaRefracFundente("CaO", 6) * IndiceConsumo("Proyectable")) _
               + (CargaRefracFundente("CaO", 5) * IndiceConsumo("Apisonable"))
               
    '' calculo del Oxido de calcio de carga
    CaO_Carga = CaO_Esc - ((CargaRefracFundente("CaO", 2) * Peso_Cal) _
                           + (CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                           + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
                           + CaO_ref)
                           
    '' comprobar balance calcio
    Entradas = CaO_ref + CaO_Carga + (CargaRefracFundente("CaO", 2) * Peso_Cal) _
                                   + (CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                                   + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo"))
    Salida = CaO_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Calcio incorrecto")
    
    ''' si CaO_Carga es negativo, no hay oxido de calcio en la carga, el CaO es solo que que se adiciona en la cal
    If CaO_Carga <= 0 Then
    '' Porciento de Oxido de Calcio en la CAL en '' kg / ton Ac liq
    CaO_Cal = CaO_Esc - ((CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                         + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
                         + CaO_ref)
    Else
    CaO_Cal = CaO_Esc - ((CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
                         + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
                         + CaO_ref _
                         + CaO_Carga)
    End If
    
    '' Porciento de oxido de calcio en la cal real por tonelada de cal
    CaO_CalReal = (CaO_Cal * 100) / Peso_Cal
    
    
    
    
    
    
    ''*************balance del oxido de Magnesio
    'MgO_Esc = 5.1
    Dim MgO_ref As Single, MgO_Carga As Single, MgO_Cal As Single, MgO_CalReal As Single
    
    '' calculo del oxido de magnesio de refractario
    MgO_ref = (CargaRefracFundente("MgO", 3) * IndiceConsumo("LadrilloPared")) _
               + (CargaRefracFundente("MgO", 4) * IndiceConsumo("CentroBobeda")) _
               + (CargaRefracFundente("MgO", 6) * IndiceConsumo("Proyectable")) _
               + (CargaRefracFundente("MgO", 5) * IndiceConsumo("Apisonable"))
               
    '' calculo del Oxido de calcio de carga
    MgO_Carga = MgO_Esc - ((CargaRefracFundente("MgO", 2) * Peso_Cal) _
                           + (CargaRefracFundente("MgO", 1) * Peso_Dolomita) _
                           + MgO_ref)
   
   '' comprobar balance magnesio
    Entradas = MgO_ref + MgO_Carga + (CargaRefracFundente("MgO", 2) * Peso_Cal) _
                                   + (CargaRefracFundente("MgO", 1) * Peso_Dolomita)

    Salida = MgO_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido Magnesio incorrecto")
    
    ''' si MgO_Carga es negativo, no hay oxido de calcio en la carga, el CaO es solo que que se adiciona en la cal
    If MgO_Carga <= 0 Then
    '' Porciento de Oxido de Calcio en la CAL en '' kg / ton Ac liq
    MgO_Cal = MgO_Esc - ((CargaRefracFundente("MgO", 1) * Peso_Dolomita) _
                         + MgO_ref)
    Else
    MgO_Cal = MgO_Esc - ((CargaRefracFundente("MgO", 1) * Peso_Dolomita) _
                         + MgO_ref _
                         + MgO_Carga)
    End If
    
    '' Porciento de oxido de calcio en la cal real por tonelada de cal
    MgO_CalReal = (MgO_Cal * 100) / Peso_Cal
    
    
    
    
    
    ''*************balance del oxido de aluminio (Alumina)
    'Al2O3_Esc = 5.6: Al_Metal = 0.21
    Dim Al2O3_ref As Single, Al2O3_ox As Single, Al2O3_Carga As Single, Al2O3_AcLiq As Single, Al2O3_Cal As Single, Al2O3_CalReal As Single
    
    '' calculo del oxido de alumino de oxidacion
    Al2O3_ox = Al2O3_Esc * (OxidoRelacEsteq("Al2O3", 0) / OxidoRelacEsteq("Al2O3", 1)) ''el peso atomico es el del elemento Si'' se busca asi en la base de datos

    '' calculo del oxido de silicio de refractario
    Al2O3_ref = (CargaRefracFundente("Al2O3", 3) * IndiceConsumo("LadrilloPared")) _
                 + (CargaRefracFundente("Al2O3", 4) * IndiceConsumo("CentroBobeda")) _
                 + (CargaRefracFundente("Al2O3", 6) * IndiceConsumo("Proyectable")) _
                 + (CargaRefracFundente("Al2O3", 5) * IndiceConsumo("Apisonable"))
    '' conversion del Si del Ac liquido a oxido de silicio
    Al2O3_AcLiq = (Al_Metal * BaseAcero / 100) * (OxidoRelacEsteq("Al2O3", 1) / (OxidoRelacEsteq("Al2O3", 0) * 2))
    
    '' calculo del Oxido de silicio de carga
    Al2O3_Carga = Al2O3_Esc + Al2O3_AcLiq - (Al2O3_ox + (CargaRefracFundente("Al2O3", 2) * Peso_Cal) _
                                                      + (CargaRefracFundente("Al2O3", 1) * Peso_Dolomita) _
                                                      + (CargaRefracFundente("Al2O3", 7) * IndiceConsumo("CenizaElectrodo")) _
                                                      + Al2O3_ref)
    '' comprobar balance silicio
    Entradas = Al2O3_ref + Al2O3_Carga + Al2O3_ox + (CargaRefracFundente("Al2O3", 2) * Peso_Cal) _
                                                  + (CargaRefracFundente("Al2O3", 1) * Peso_Dolomita) _
                                                  + (CargaRefracFundente("Al2O3", 7) * IndiceConsumo("CenizaElectrodo"))
    Salida = Al2O3_AcLiq + Al2O3_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Aluminio (Alumina) incorrecto")
    
        ''' si Al2O3_Carga es negativo, no hay oxido de calcio en la carga, el CaO es solo que que se adiciona en la cal
    If Al2O3_Carga <= 0 Then
      '' Porciento de Oxido de Calcio en la CAL en '' kg / ton Ac liq
      Al2O3_Cal = Al2O3_Esc + Al2O3_AcLiq - ((CargaRefracFundente("Al2O3", 1) * Peso_Dolomita) _
                                             + (CargaRefracFundente("Al2O3", 7) * IndiceConsumo("CenizaElectrodo")) _
                                             + Al2O3_ref _
                                             + Al2O3_ox)
    Else
      Al2O3_Cal = Al2O3_Esc + Al2O3_AcLiq - ((CargaRefracFundente("Al2O3", 1) * Peso_Dolomita) _
                                             + (CargaRefracFundente("Al2O3", 7) * IndiceConsumo("CenizaElectrodo")) _
                                             + Al2O3_ref _
                                             + Al2O3_ox _
                                             + Al2O3_Carga)
    End If
    
    '' Porciento de oxido de calcio en la cal real por tonelada de cal
    Al2O3_CalReal = (Al2O3_Cal * 100) / Peso_Cal
    
    '' Silicio Oxidado o Silicio que se Oxida
    Dim Al_ox As Single
    Al_ox = Al2O3_ox * (OxidoRelacEsteq("Al2O3", 0) / OxidoRelacEsteq("Al2O3", 1))
    
    '' calculo del de silicio de carga
    Dim Al_Carga As Single
    Al_Carga = Al_ox + Al_Metal '' kg / ton Ac liq
    
    '' porciento de silicio en carga
    Dim Al_CargaPorciento As Single
    Al_CargaPorciento = (Al_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim Al_Perdida As Single
    Al_Perdida = Al_Carga - ((Al_Metal * BaseAcero) / 100) '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim Al_PerdidaPorciento As Single
    Al_PerdidaPorciento = (Al_Perdida / Al_Carga) * 100 '' %
    
    
    
    
    
    ''*************balance del oxido de Manganeso
    'MnO_Esc = 6.15: Mn_Metal = 0.1
    Dim MnO_ox As Single, MnO_Carga As Single, MnO_AcLiq As Single
    
    '' calculo del oxido de alumino de oxidacion
    ''MnO_ox = MnO_Esc * (OxidoRelacEsteq("MnO", 0) / OxidoRelacEsteq("MnO", 1)) ''el peso atomico es el del elemento Si'' se busca asi en la base de datos
    
    ' conversion del Si del Ac liquido a oxido de silicio '' kg / ton Ac liq
    MnO_AcLiq = (Mn_Metal * BaseAcero / 100) * (OxidoRelacEsteq("MnO", 1) / OxidoRelacEsteq("MnO", 0))
    
    '' calculo del Oxido de silicio de carga
    MnO_Carga = MnO_Esc + MnO_AcLiq '- MnO_ox
    
    '' comprobar balance silicio
    Entradas = MnO_Carga + MnO_ox
    
    Salida = MnO_AcLiq + MnO_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Manganeso incorrecto")
    
    '' Silicio Oxidado o Silicio que se Oxida
    Dim Mn_ox As Single
    'Mn_ox = MnO_ox * (OxidoRelacEsteq("MnO", 0) / OxidoRelacEsteq("MnO", 1))
    
    '' calculo del de silicio de carga
    Dim Mn_Carga As Single
    Mn_Carga = MnO_Carga * (OxidoRelacEsteq("MnO", 0) / OxidoRelacEsteq("MnO", 1)) '' kg / ton Ac liq
    
    '' porciento de silicio en carga
    Dim Mn_CargaPorciento As Single
    Mn_CargaPorciento = (Mn_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim Mn_Perdida As Single
    Mn_Perdida = Mn_Carga - ((Mn_Metal * BaseAcero) / 100) '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim Mn_PerdidaPorciento As Single
    Mn_PerdidaPorciento = (Mn_Perdida / Mn_Carga) * 100 '' %
    
    
    
    
    
    ''*************balance del oxido de Hierro FeO ''' El Fe2O3 esta incluido en este balance
    'FeO_Esc = 26.54: Fe_Metal = 99.796
    Dim FeO_ox As Single, FeO_Carga As Single, FeO_AcLiq As Single, FeO_Polvo As Single
    
    '' calculo del oxido de hierro de oxidacion
    'FeO_ox = FeO_Esc * (OxidoRelacEsteq("FeO", 0) / OxidoRelacEsteq("FeO", 1))
    
    ' conversion del Si del Ac liquido a oxido de silicio '' kg / ton Ac liq
    FeO_AcLiq = (Fe_Metal * BaseAcero / 100) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
    
    '' Hierro que se oxida
    Dim Fe_ox As Single
    Fe_ox = FeO_Esc * (OxidoRelacEsteq("FeO", 0) / OxidoRelacEsteq("FeO", 1))
    
    '' Perdida del elemento
    Dim Fe_Perdida As Single
    Fe_Perdida = (Fe_ox * 100) / 15
    
    '' Hierro del Acero
    Dim Fe_Acero As Single
    Fe_Acero = (Fe_Metal * BaseAcero / 100)
    
    '' calculo del Fe de carga
    Dim Fe_Carga As Single
    Fe_Carga = Fe_Perdida + Fe_Acero '+ FeO_Polvo '- FeO_ox
    
    '' calculo del FeO de carga
    FeO_Carga = Fe_Carga * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
    
    '' Hierro del polvo o que se va en Humos
    FeO_Polvo = FeO_Carga - (FeO_AcLiq + FeO_Esc)
    
    '' comprobar balance silicio
    Entradas = FeO_Carga
    Salida = FeO_AcLiq + FeO_Polvo + FeO_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Hierro incorrecto")
    
    '' recalcular oxido de polvo ''' 0.03 estimado para carga metalica 3%
    FeO_Polvo = (Fe_Carga * 0.03) * (OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))
    
    '' recalculo del FeO de carga
    FeO_Carga = FeO_AcLiq + FeO_Esc + FeO_Polvo
    
    '' recalculo del Fe de carga en kg / ton Ac liq
    Fe_Carga = FeO_Carga * (OxidoRelacEsteq("FeO", 0) / OxidoRelacEsteq("FeO", 1))
    
    '' porciento de silicio en carga
    Dim Fe_CargaPorciento As Single
    Fe_CargaPorciento = (Fe_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Fe_Perdida = Fe_Carga - ((Fe_Metal * BaseAcero) / 100) '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim Fe_PerdidaPorciento As Single
    Fe_PerdidaPorciento = (Fe_Perdida / Fe_Carga) * 100 '' %
    
    '' recalcular pociento FeO de polvo ''' en porciento
    Dim FeO_PolvoPorciento As Single
    FeO_PolvoPorciento = (FeO_Polvo * 100) / (Fe_Carga * ((OxidoRelacEsteq("FeO", 1) / OxidoRelacEsteq("FeO", 0))))
    
    
    
    
    
    
    ''*************balance del oxido de Fosforo
    'P2O5_Esc = 0: P_Metal = 0.012
    Dim P2O5_Carga As Single, P2O5_ParticionEscMet As Single
    
    ''' si no se da se estima
    If P2O5_Esc <= 0 Then
       P2O5_ParticionEscMet = 1.5 * (((CaO_Esc * FeO_Esc) / SiO2_Esc) ^ 0.69)
       P2O5_Esc = P_Metal * P2O5_ParticionEscMet
    End If

    ''' conversion P a oxido de fosforo en el acero
    Dim P2O5_AcLiq As Single
    P2O5_AcLiq = (P_Metal * BaseAcero / 100) * (OxidoRelacEsteq("P2O5", 1) / (OxidoRelacEsteq("P2O5", 0) * 2))
    
    '' Oxido de Fosforo en carga
    P2O5_Carga = P2O5_Esc + P2O5_AcLiq
    
    '' comprobar balance silicio
    Entradas = P2O5_Carga
    Salida = P2O5_AcLiq + P2O5_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Pentoxido de Difosforo incorrecto")
      
    '' Fosforo Oxidado
    Dim P_ox As Single
    P_ox = P2O5_Esc * ((OxidoRelacEsteq("P2O5", 0) * 2) / OxidoRelacEsteq("P2O5", 1))
    
    '' Fosforo en la Carga
    Dim P_Carga As Single
    P_Carga = P2O5_Carga * ((OxidoRelacEsteq("P2O5", 0) * 2) / OxidoRelacEsteq("P2O5", 1))
     
    '' porciento de silicio en carga
    Dim P_CargaPorciento As Single
    P_CargaPorciento = (P_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim P_Perdida As Single
    P_Perdida = P_Carga - ((P_Metal * BaseAcero) / 100) '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim P_PerdidaPorciento As Single
    P_PerdidaPorciento = (P_Perdida / P_Carga) * 100 '' %
     
     
     
     
     
    '''''*************balance del oxido de Asufre
    'S_Esc = 0: S_Metal = 0.045
    Dim S_Carga As Single, S_Esc_ParticionEscMet As Single
    
    ''' si no se da se estima
    If S_Esc <= 0 Then
       S_Esc_ParticionEscMet = 5 * ((CaO_Esc / (SiO2_Esc * FeO_Esc)) ^ 0.48)
       S_Esc = S_Metal * S_Esc_ParticionEscMet
    End If
 
    ''' conversion P a oxido de fosforo en el acero
    Dim S_AcLiq As Single
    S_AcLiq = (S_Metal * BaseAcero / 100)
     
    ''' elemnto oxidado
    Dim S_ox As Single
    S_ox = S_Esc
     
    ''' en la caraga
    S_Carga = S_AcLiq + S_ox '' kg / ton Ac liq
    
    '' comprobar balance silicio
    Entradas = S_Carga
    Salida = S_AcLiq + S_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Asufre incorrecto")
     
    '' porciento de silicio en carga
    Dim S_CargaPorciento As Single
    S_CargaPorciento = (S_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim S_Perdida As Single
    S_Perdida = S_ox '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim S_PerdidaPorciento As Single
    S_PerdidaPorciento = (S_Perdida / S_Carga) * 100 '' %
    
    
    
    
    
     '''''*************balance del Cromo
    'Cr2O3_Esc = 0: Cr_Metal = 0.09
    Dim Cr2O3_Carga As Single, Cr2O3_Esc_ParticionEscMet As Single
    
    ''' si no se da se estima
    If Cr2O3_Esc <= 0 Then
       Cr2O3_Esc_ParticionEscMet = 0.5 * FeO_Esc
       Cr2O3_Esc = Cr_Metal * Cr2O3_Esc_ParticionEscMet
    End If
    
    ''' Cromo oxidado
    Dim Cr_ox As Single
    Cr_ox = Cr2O3_Esc * ((OxidoRelacEsteq("Cr2O3", 0) * 2) / OxidoRelacEsteq("Cr2O3", 1))
    
    ''' conversion P a oxido de fosforo en el acero
    Dim Cr_AcLiq As Single
    Cr_AcLiq = (Cr_Metal * BaseAcero / 100) * ((OxidoRelacEsteq("Cr2O3", 1) / (OxidoRelacEsteq("Cr2O3", 0) * 2)))
    
    ''' cromo en la carga
     Cr2O3_Carga = Cr2O3_Esc + Cr_AcLiq
    
    '' comprobar balance silicio
    Entradas = Cr2O3_Carga
    Salida = Cr_AcLiq + Cr2O3_Esc
    If Entradas <> Salida Then MsgBox ("Balance de Oxido de Cromo incorrecto")
    
    ''' comprobar Cromo de la carga
    Dim Cr_Carga As Single, Cr_Carga2 As Single
    Cr_Carga = Cr_Metal + Cr_ox
    Cr_Carga2 = Cr2O3_Carga * (((OxidoRelacEsteq("Cr2O3", 0) * 2) / OxidoRelacEsteq("Cr2O3", 1)))
    
        '' porciento de silicio en carga
    Dim Cr_CargaPorciento As Single
    Cr_CargaPorciento = (Cr_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita)) * 100 '' en %
    
    '' perdida del Si
    Dim Cr_Perdida As Single
    Cr_Perdida = Cr_ox '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim Cr_PerdidaPorciento As Single
    Cr_PerdidaPorciento = (Cr_Perdida / Cr_Carga) * 100 '' %

    
    
    
    
    
     '''''*************balance del C
    'C_Esc = 0: C_Metal = 0.09
    Dim C_Carga As Single
    
    ''' Estimar composicion de los gases
    Dim CO As Single, CO2 As Single, Masa_Gases As Single, Peso_Gases As Single
    CO = 26: CO2 = 12: Masa_Gases = 187.5 'kg / ton Ac liq
    
    '' peso de los gases
    Peso_Gases = Masa_Gases * 22.4 '' 22.4 volumen molar de gase
    
    '' masa de CO
    Dim CO_masa As Single
    CO_masa = (CO * Masa_Gases) / 100
    
    '' masa de CO2
    Dim CO2_masa As Single
    CO2_masa = (CO2 * Masa_Gases) / 100
    
    ''' combertir a Carbono
    Dim C_Carbono As Single
    C_Carbono = (CO_masa * ((OxidoRelacEsteq("CO", 0) / OxidoRelacEsteq("CO", 1)))) _
               + (CO2_masa * ((OxidoRelacEsteq("CO2", 0) / OxidoRelacEsteq("CO2", 1))))
               
    ''' carbono del acero
    Dim C_AcLiq As Single
    C_AcLiq = (C_Metal * BaseAcero / 100)
    
    '' carbono de carga
    C_Carga = C_AcLiq + C_Carbono - (Peso_Carbon + IndiceConsumo("PuntaElectrodo"))
    
    '' comprobar balance silicio
    Entradas = C_Carga + Peso_Carbon + IndiceConsumo("PuntaElectrodo")
    Salida = C_AcLiq + C_Carbono
    If Entradas <> Salida Then MsgBox ("Balance de Carbono incorrecto")
    
    '' porciento de silicio en carga
    Dim C_CargaPorciento As Single
    C_CargaPorciento = (C_Carga / (Peso_Carga_MetalicaTotal + Peso_Cal + Peso_Dolomita + Peso_Carbon)) * 100 '' en %
    
    '' perdida del Si
    Dim C_Perdida As Single
    C_Perdida = C_Carga - C_AcLiq '' kg / ton Ac liq
    
    '' perdida del Si en %
    Dim C_PerdidaPorciento As Single
    C_PerdidaPorciento = (C_Perdida / C_Carga) * 100 '' %
    
    
    
    
    
    
    
    
End Sub


'''Oxidos de carga metalica en refrac y fund
Private Function OxidosDeCargas(Oxido As String, HBI_AcL As Single, ChatarraLigera_AcL As Single, Escarpa_AcL As Single, HierroFundido_AcL As Single, ChatarraPesada_AcL As Single, Paca_AcL As Single, HRD_AcL As Single) As Single
OxidosDeCargas = (HBI_AcL * CargaMetalica(Oxido, 0)) _
              + (ChatarraLigera_AcL * CargaMetalica(Oxido, 1)) _
              + (Escarpa_AcL * CargaMetalica(Oxido, 2)) _
              + (HierroFundido_AcL * CargaMetalica(Oxido, 3)) _
              + (ChatarraPesada_AcL * CargaMetalica(Oxido, 4)) _
              + (Paca_AcL * CargaMetalica(Oxido, 5)) _
              + (HRD_AcL * CargaMetalica(Oxido, 7)) _
              + (CargaRefracFundente(Oxido, 3) * IndiceConsumo("LadrilloPared")) _
              + (CargaRefracFundente(Oxido, 4) * IndiceConsumo("CentroBobeda")) _
              + (CargaRefracFundente(Oxido, 6) * IndiceConsumo("Proyectable")) _
              + (CargaRefracFundente(Oxido, 5) * IndiceConsumo("Apisonable")) _
              + (CargaRefracFundente(Oxido, 8) * Peso_EscoriaRem) _
              + (CargaRefracFundente(Oxido, 2) * Peso_Cal) _
              + (CargaRefracFundente(Oxido, 1) * Peso_Dolomita) _
              + (CargaRefracFundente(Oxido, 7) * IndiceConsumo("CenizaElectrodo"))

End Function


Public Sub LeeDatosOxidos()

'   Set bddatosCalculos = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
'   Set rsbddatos = sibd.OpenRecordset("DatosOxidos", dbOpenDynaset)
'   If Not rsbddatos.BOF Then rsbddatos.MoveFirst
'   While Not rsbddatos.EOF
'
'     rsbddatos.MoveNext ' mover al proximo
'   Wend
   
'  Do Until rsbprin!NOMBRE = Combo1.List(Combo1.ListIndex)
'   rsbprin.MoveNext
'  Loop
  
'  rsbddatos.Close
'  bddatosCalculos.Close
  
End Sub
