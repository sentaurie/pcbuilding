﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.UserControl11 = New PCBuilding.UserControl1()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(66, 285)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(277, 49)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "AMD Ryzen 7 5700X3D"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(66, 230)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(277, 49)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "AMD Ryzen 5 8600G"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(66, 175)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(277, 49)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "Intel Core i9-14900K"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(66, 120)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(277, 49)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Intel Core i7-14700K"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(66, 65)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(277, 49)
        Me.Button10.TabIndex = 30
        Me.Button10.Text = "GIGABYTE B550M AORUS ELITE AX"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(465, 38)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.picture = Nothing
        Me.UserControl11.Size = New System.Drawing.Size(282, 363)
        Me.UserControl11.TabIndex = 39
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents UserControl11 As UserControl1
End Class
