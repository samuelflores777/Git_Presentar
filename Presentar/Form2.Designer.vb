<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertarIPVMIXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASIGOVERLAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Overlay01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Overlay02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Overlay03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Overlay04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASIGÍSTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(262, 355)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ABRIR CANCION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(12, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "MOSTRAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCoral
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(148, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 43)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "OCULTAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(426, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(426, 146)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(29, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(474, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(474, 146)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(415, 198)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(292, 221)
        Me.TextBox5.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarIPVMIXToolStripMenuItem, Me.ASIGOVERLAYToolStripMenuItem, Me.ASIGÍSTAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 70)
        '
        'InsertarIPVMIXToolStripMenuItem
        '
        Me.InsertarIPVMIXToolStripMenuItem.Name = "InsertarIPVMIXToolStripMenuItem"
        Me.InsertarIPVMIXToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.InsertarIPVMIXToolStripMenuItem.Text = "Insertar IP vMIX"
        '
        'ASIGOVERLAYToolStripMenuItem
        '
        Me.ASIGOVERLAYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Overlay01ToolStripMenuItem, Me.Overlay02ToolStripMenuItem, Me.Overlay03ToolStripMenuItem, Me.Overlay04ToolStripMenuItem})
        Me.ASIGOVERLAYToolStripMenuItem.Name = "ASIGOVERLAYToolStripMenuItem"
        Me.ASIGOVERLAYToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ASIGOVERLAYToolStripMenuItem.Text = "NUM. OVERLAY"
        '
        'Overlay01ToolStripMenuItem
        '
        Me.Overlay01ToolStripMenuItem.Name = "Overlay01ToolStripMenuItem"
        Me.Overlay01ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Overlay01ToolStripMenuItem.Text = "Overlay 01"
        '
        'Overlay02ToolStripMenuItem
        '
        Me.Overlay02ToolStripMenuItem.Name = "Overlay02ToolStripMenuItem"
        Me.Overlay02ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Overlay02ToolStripMenuItem.Text = "Overlay 02"
        '
        'Overlay03ToolStripMenuItem
        '
        Me.Overlay03ToolStripMenuItem.Name = "Overlay03ToolStripMenuItem"
        Me.Overlay03ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Overlay03ToolStripMenuItem.Text = "Overlay 03"
        '
        'Overlay04ToolStripMenuItem
        '
        Me.Overlay04ToolStripMenuItem.Name = "Overlay04ToolStripMenuItem"
        Me.Overlay04ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.Overlay04ToolStripMenuItem.Text = "Overlay 04"
        '
        'ASIGÍSTAToolStripMenuItem
        '
        Me.ASIGÍSTAToolStripMenuItem.Name = "ASIGÍSTAToolStripMenuItem"
        Me.ASIGÍSTAToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ASIGÍSTAToolStripMenuItem.Text = "NUM. CANAL"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Crimson
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox6.Location = New System.Drawing.Point(12, 479)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(130, 22)
        Me.TextBox6.TabIndex = 10
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(426, 38)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(29, 20)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(426, 12)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(29, 20)
        Me.TextBox8.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(148, 474)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 31)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "GUARDAR_IP"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnIP})
        Me.DataGridView1.Location = New System.Drawing.Point(520, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'ColumnIP
        '
        Me.ColumnIP.HeaderText = "IPVMIX"
        Me.ColumnIP.Name = "ColumnIP"
        Me.ColumnIP.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(290, 516)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENVIAR CANCIONES AL vMIX"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InsertarIPVMIXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASIGOVERLAYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Overlay01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Overlay02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Overlay03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Overlay04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASIGÍSTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnIP As DataGridViewTextBoxColumn
End Class
