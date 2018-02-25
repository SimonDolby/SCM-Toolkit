Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class PreferenceTests

    <TestMethod()>
    Public Sub SaveSettings()

        My.Settings.DatabaseLocation = "Hello this is literally a test"

    End Sub

    <TestMethod()>
    Public Sub LoadSettings()

        MessageBox.Show(My.Settings.DatabaseLocation)

    End Sub


End Class