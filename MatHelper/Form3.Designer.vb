<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.результат = New System.Windows.Forms.TextBox()
        Me.кл_деления = New System.Windows.Forms.Button()
        Me.кл_умножения = New System.Windows.Forms.Button()
        Me.кл_вычитания = New System.Windows.Forms.Button()
        Me.кл_сложения = New System.Windows.Forms.Button()
        Me.число2 = New System.Windows.Forms.TextBox()
        Me.число1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Сброс"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Результат"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Второе число"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Первое число"
        '
        'результат
        '
        Me.результат.Location = New System.Drawing.Point(100, 129)
        Me.результат.Name = "результат"
        Me.результат.Size = New System.Drawing.Size(246, 20)
        Me.результат.TabIndex = 34
        '
        'кл_деления
        '
        Me.кл_деления.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.кл_деления.Location = New System.Drawing.Point(301, 68)
        Me.кл_деления.Name = "кл_деления"
        Me.кл_деления.Size = New System.Drawing.Size(45, 45)
        Me.кл_деления.TabIndex = 33
        Me.кл_деления.Text = ":"
        Me.кл_деления.UseVisualStyleBackColor = True
        '
        'кл_умножения
        '
        Me.кл_умножения.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.кл_умножения.Location = New System.Drawing.Point(237, 68)
        Me.кл_умножения.Name = "кл_умножения"
        Me.кл_умножения.Size = New System.Drawing.Size(45, 45)
        Me.кл_умножения.TabIndex = 32
        Me.кл_умножения.Text = "х"
        Me.кл_умножения.UseVisualStyleBackColor = True
        '
        'кл_вычитания
        '
        Me.кл_вычитания.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.кл_вычитания.Location = New System.Drawing.Point(168, 68)
        Me.кл_вычитания.Name = "кл_вычитания"
        Me.кл_вычитания.Size = New System.Drawing.Size(45, 45)
        Me.кл_вычитания.TabIndex = 31
        Me.кл_вычитания.Text = "-"
        Me.кл_вычитания.UseVisualStyleBackColor = True
        '
        'кл_сложения
        '
        Me.кл_сложения.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.кл_сложения.Location = New System.Drawing.Point(100, 68)
        Me.кл_сложения.Name = "кл_сложения"
        Me.кл_сложения.Size = New System.Drawing.Size(45, 45)
        Me.кл_сложения.TabIndex = 30
        Me.кл_сложения.Text = "+"
        Me.кл_сложения.UseVisualStyleBackColor = True
        '
        'число2
        '
        Me.число2.Location = New System.Drawing.Point(100, 42)
        Me.число2.Name = "число2"
        Me.число2.Size = New System.Drawing.Size(246, 20)
        Me.число2.TabIndex = 29
        '
        'число1
        '
        Me.число1.Location = New System.Drawing.Point(99, 6)
        Me.число1.Name = "число1"
        Me.число1.Size = New System.Drawing.Size(247, 20)
        Me.число1.TabIndex = 28
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 193)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.результат)
        Me.Controls.Add(Me.кл_деления)
        Me.Controls.Add(Me.кл_умножения)
        Me.Controls.Add(Me.кл_вычитания)
        Me.Controls.Add(Me.кл_сложения)
        Me.Controls.Add(Me.число2)
        Me.Controls.Add(Me.число1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "MatHelper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents результат As System.Windows.Forms.TextBox
    Friend WithEvents кл_деления As System.Windows.Forms.Button
    Friend WithEvents кл_умножения As System.Windows.Forms.Button
    Friend WithEvents кл_вычитания As System.Windows.Forms.Button
    Friend WithEvents кл_сложения As System.Windows.Forms.Button
    Friend WithEvents число2 As System.Windows.Forms.TextBox
    Friend WithEvents число1 As System.Windows.Forms.TextBox
End Class
