' Library Database Main Module (modLibrary.vb)
' Written by Bart Cabuyao
' Date: 6/5/2022, 11:59p

Imports System.Data.SQLite

Module modLibrary
    Public Database As New SQLiteConnection("Data Source=db\LibDB.db")
    Public Query As New SQLiteCommand
    Public Reader As SQLiteDataReader
End Module
