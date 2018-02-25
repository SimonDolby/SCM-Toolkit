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
        Me.btnOrderFulfilment = New System.Windows.Forms.Button()
        Me.BtnTransportManagement = New System.Windows.Forms.Button()
        Me.btnLogisticsManage = New System.Windows.Forms.Button()
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
        Me.Splitter1.Size = New System.Drawing.Size(142, 292)
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
        'btnOrderFulfilment
        '
        Me.btnOrderFulfilment.BackColor = System.Drawing.Color.PowderBlue
        Me.btnOrderFulfilment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderFulfilment.Location = New System.Drawing.Point(0, 144)
        Me.btnOrderFulfilment.Name = "btnOrderFulfilment"
        Me.btnOrderFulfilment.Size = New System.Drawing.Size(142, 50)
        Me.btnOrderFulfilment.TabIndex = 4
        Me.btnOrderFulfilment.Text = "Order Fulfilment"
        Me.btnOrderFulfilment.UseVisualStyleBackColor = False
        '
        'BtnTransportManagement
        '
        Me.BtnTransportManagement.BackColor = System.Drawing.Color.PowderBlue
        Me.BtnTransportManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransportManagement.Location = New System.Drawing.Point(0, 193)
        Me.BtnTransportManagement.Name = "BtnTransportManagement"
        Me.BtnTransportManagement.Size = New System.Drawing.Size(142, 50)
        Me.BtnTransportManagement.TabIndex = 5
        Me.BtnTransportManagement.Text = "Transportation Management"
        Me.BtnTransportManagement.UseVisualStyleBackColor = False
        '
        'btnLogisticsManage
        '
        Me.btnLogisticsManage.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogisticsManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogisticsManage.Location = New System.Drawing.Point(0, 242)
        Me.btnLogisticsManage.Name = "btnLogisticsManage"
        Me.btnLogisticsManage.Size = New System.Drawing.Size(142, 50)
        Me.btnLogisticsManage.TabIndex = 6
        Me.btnLogisticsManage.Text = "Logistics Management"
        Me.btnLogisticsManage.UseVisualStyleBackColor = False
        '
        'Toolkit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 292)
        Me.Controls.Add(Me.btnLogisticsManage)
        Me.Controls.Add(Me.BtnTransportManagement)
        Me.Controls.Add(Me.btnOrderFulfilment)
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
    Friend WithEvents btnOrderFulfilment As Button
    Friend WithEvents BtnTransportManagement As Button
    Friend WithEvents btnLogisticsManage As Button
End Class
