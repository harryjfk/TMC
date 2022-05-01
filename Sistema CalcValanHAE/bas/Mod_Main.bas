Attribute VB_Name = "Mod_Main"
Option Explicit

Private Sub Main()
Dim CO_PA As Single

'' arranque del programa
BaseAcero = 1000
BaseEscoria = 100

'' en toneladas
AcLiquido = 70
Carga_MetalicaTotal = 75.1
Cal_MasaTotal = 3.1
Dolomita_MasaTotal = 0.075
Carbon_MasaTotal = 0.14

'' datos del aire
Aire_Comp = 100
Nitrogeno_Aire = 79
Oxigeno_Aire = 21
Dens_Aire = 1.29
Dens_Nitrogeno = 1.25
Dens_Oxigeno = 1.43
Vol_Aire = 29.6
Vol_Nitrogeno = 23.38
Vol_Oxigeno = 6.22

EscoriaRem_MasaTotal = 2 'en Ton

Oxigeno_EficInyectado = 75 ' en %

' gases de combustion
CO = 0: CO2 = 0
Dens_CO = 1.25 '' kg/NM3
Dens_CO2 = 196 '' kg/NM3

'' pasar al modulo despues y poner privadas las variables
Peso_Carga_MetalicaTotal = (Carga_MetalicaTotal * BaseAcero) / AcLiquido ''' kg / Ton de Ac liq
Peso_Cal = (Cal_MasaTotal * BaseAcero) / AcLiquido ''' kg / Ton de Ac liq
Peso_Dolomita = (Dolomita_MasaTotal * BaseAcero) / AcLiquido ''' kg / Ton de Ac liq
Peso_Carbon = (Carbon_MasaTotal * BaseAcero) / AcLiquido ''' kg / Ton de Ac liq

'' escoria remane
Peso_EscoriaRem = (EscoriaRem_MasaTotal * BaseAcero) / AcLiquido ''' kg / Ton de Ac liq

  Call Carga_Segun_Escoria_Metal
 
 'Call Escoria_Segun_Carga_Metal
 
 
 
 
 
 
 
 
End Sub
