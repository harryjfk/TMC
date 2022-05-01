Attribute VB_Name = "Mod_GestaDatos"
Option Explicit
Dim bd As DAO.Database
Dim rs As DAO.Recordset

'''****************************************************************************
''' MODULO PARA LA BUSQUEDA DE DATOS EN LA BD DEL PROGRAMA
'''****************************************************************************

'''Funcion para buscar relaciones estequiometricas en base de datos
Public Function OxidoRelacEsteq(Elemento As String, variante As Byte) As Single
    Set bd = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
    Set rs = bd.OpenRecordset("DatosOxidos", dbOpenDynaset)
    If Not rs.BOF Then rs.MoveFirst
    Do Until rs!Elemento = Elemento
     rs.MoveNext
    Loop
    Select Case variante
        Case 0
        OxidoRelacEsteq = rs!PesoAtomico
        Case 1
        OxidoRelacEsteq = rs!PesoMolecular
        Case 2
        OxidoRelacEsteq = rs!RelacionOxigenoElemento
    End Select
    rs.Close
    bd.Close
End Function

'''Funcion para buscar carga de refractarios y fundentes en base de datos
Public Function CargaRefracFundente(Concepto As String, Campo As Byte) As Single
    Set bd = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
    Set rs = bd.OpenRecordset("CargaRefractarioFundente", dbOpenDynaset)
    If Not rs.BOF Then rs.MoveFirst
    Do Until rs!Concepto = Concepto
     rs.MoveNext
    Loop
    Select Case Campo
        Case 0
        CargaRefracFundente = rs!Carbon
        Case 1
        CargaRefracFundente = rs!Dolomita
        Case 2
        CargaRefracFundente = rs!Cal
        Case 3
        CargaRefracFundente = rs!LadrilloPared
        Case 4
        CargaRefracFundente = rs!CentroBobeda
        Case 5
        CargaRefracFundente = rs!Apisonable
        Case 6
        CargaRefracFundente = rs!Proyectable
        Case 7
        CargaRefracFundente = rs!CenizaElectrodo
        Case 8
        CargaRefracFundente = rs!EscoriaRemanente
    End Select
    rs.Close
    bd.Close
    
    '' llevarlo a  fraccion de 100
    CargaRefracFundente = CargaRefracFundente / 100
    
End Function

'''Funcion para buscar carga metalica en base de datos
Public Function CargaMetalica(Concepto As String, Campo As Byte) As Single
    Set bd = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
    Set rs = bd.OpenRecordset("CargaMetalica", dbOpenDynaset)
    If Not rs.BOF Then rs.MoveFirst
    Do Until rs!Concepto = Concepto
     rs.MoveNext
    Loop
    Select Case Campo
        Case 0
        CargaMetalica = rs!HBI
        Case 1
        CargaMetalica = rs!ChatarraLigera
        Case 2
        CargaMetalica = rs!Escarpa
        Case 3
        CargaMetalica = rs!HierroFundido
        Case 4
        CargaMetalica = rs!ChatarraPesada
        Case 5
        CargaMetalica = rs!Paca
        Case 6
        CargaMetalica = rs!PieLiquido
    End Select
    rs.Close
    bd.Close
    '' llevarlo a  fraccion de 100
    CargaMetalica = CargaMetalica / 100
End Function

'''Funcion para buscar los indices de consumos
Public Function IndiceConsumo(Concepto As String) As Single
    Set bd = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
    Set rs = bd.OpenRecordset("IndicesConsumo", dbOpenDynaset)
    If Not rs.BOF Then rs.MoveFirst
    Do Until rs!Concepto = Concepto
     rs.MoveNext
    Loop
    IndiceConsumo = rs!IndiceConsumo
    rs.Close
    bd.Close
End Function

'''Funcion para buscar Energias de Reacciones quimicas
Public Function EnergReacQuimicas(Ecuacion As Byte, Concepto As Byte) As Single
    Set bd = OpenDatabase(App.Path & "\bin\bddatabalances.mdb", False, False, ";PWD=")
    Set rs = bd.OpenRecordset("EnergiasReacQuimicas", dbOpenDynaset)
    If Not rs.BOF Then rs.MoveFirst
    Do Until rs!NoEcuacion = Ecuacion
     rs.MoveNext
    Loop
    Select Case Concepto
        Case 0
        EnergReacQuimicas = rs!Concepto
        Case 1
        EnergReacQuimicas = rs!Concepto1
        Case 2
        EnergReacQuimicas = rs!Concepto2
        Case 3
        EnergReacQuimicas = rs!Concepto3
        Case 4
        EnergReacQuimicas = rs!Concepto4
    End Select
    rs.Close
    bd.Close
End Function

