<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolkit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDemandPlanning = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnProcurement = New System.Windows.Forms.Button()
        Me.btnWarehouseManagement = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDemandPlanning
        '
        Me.btnDemandPlanning.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDemandPlanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemandPlanning.Location = New System.Drawing.Point(0, 0)
        Me.btnDemandPlanning.Name = "btnDemandPlanning"
        Me.btnDemandPlanning.Size = New System.Drawing.Size(142, 47)
        Me.btnDemandPlanning.TabIndex = 0
        Me.btnDemandPlanning.Text = "Demand Planning"
        Me.btnDemandPlanning.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(142, 419)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'btnProcurement
        '
        Me.btnProcurement.BackColor = System.Drawing.Color.PowderBlue
        Me.btnProcurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurement.Location = New System.Drawing.Point(0, 46)
        Me.btnProcurement.Name = "btnProcurement"
        Me.btnProcurement.Size = New System.Drawing.Size(142, 50)
        Me.btnProcurement.TabIndex = 2
        Me.btnProcurement.Text = "Procurement and sourcing"
        Me.btnProcurement.UseVisualStyleBackColor = False
        '
        'btnWarehouseManagement
        '
        Me.btnWarehouseManagement.BackColor = System.Drawing.Color.PowderBlue
        Me.btnWarehouseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWarehouseManagement.Location = New System.Drawing.Point(0, 95)
        Me.btnWarehouseManagement.Name = "btnWarehouseManagement"
        Me.btnWarehouseManagement.Size = New System.Drawing.Size(142, 50)
        Me.btnWarehouseManagement.TabIndex = 3
        Me.btnWarehouseManagement.Text = "Warehouse management"
        Me.btnWarehouseManagement.UseVisualStyleBackColor = False
        '
        'Toolkit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 419)
        Me.Controls.Add(Me.btnWarehouseManagement)
        Me.Controls.Add(Me.btnProcurement)
        Me.Controls.Add(Me.btnDemandPlanning)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "Toolkit"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDemandPlanning As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents btnProcurement As Button
    Friend WithEvents btnWarehouseManagement As Button
End Class
