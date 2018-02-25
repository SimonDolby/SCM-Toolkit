Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PreferenceTests

    <TestMethod()>
    Public Sub SaveSettings()

        My.Settings.DatabaseLocationTest = "Hello this is literally a test"

    End Sub

    <TestMethod()>
    Public Sub LoadSettings()

        Messagebox.show(My.Settings.DatabaseLocationTest)

    End Sub


End Class