<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.traffic_a_green = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_a_yellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_a_red = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.traffic_b_green = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_b_yellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_b_red = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.groupbox3 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.traffic_c_green = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_c_yellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_c_red = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.traffic_d_green = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_d_yellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.traffic_d_red = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupbox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(124, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Traffic Light 1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.traffic_a_green, Me.traffic_a_yellow, Me.traffic_a_red})
        Me.ShapeContainer1.Size = New System.Drawing.Size(194, 338)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'traffic_a_green
        '
        Me.traffic_a_green.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_a_green.FillColor = System.Drawing.Color.Green
        Me.traffic_a_green.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_a_green.Location = New System.Drawing.Point(32, 232)
        Me.traffic_a_green.Name = "traffic_a_green"
        Me.traffic_a_green.Size = New System.Drawing.Size(126, 102)
        Me.traffic_a_green.Visible = False
        '
        'traffic_a_yellow
        '
        Me.traffic_a_yellow.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_a_yellow.BorderColor = System.Drawing.Color.Black
        Me.traffic_a_yellow.FillColor = System.Drawing.Color.Yellow
        Me.traffic_a_yellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_a_yellow.Location = New System.Drawing.Point(35, 120)
        Me.traffic_a_yellow.Name = "traffic_a_yellow"
        Me.traffic_a_yellow.Size = New System.Drawing.Size(126, 102)
        Me.traffic_a_yellow.Visible = False
        '
        'traffic_a_red
        '
        Me.traffic_a_red.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_a_red.FillColor = System.Drawing.Color.Red
        Me.traffic_a_red.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_a_red.Location = New System.Drawing.Point(36, 4)
        Me.traffic_a_red.Name = "traffic_a_red"
        Me.traffic_a_red.Size = New System.Drawing.Size(126, 102)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(424, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 357)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Traffic Light 2"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.traffic_b_green, Me.traffic_b_yellow, Me.traffic_b_red})
        Me.ShapeContainer2.Size = New System.Drawing.Size(194, 338)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'traffic_b_green
        '
        Me.traffic_b_green.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_b_green.FillColor = System.Drawing.Color.Green
        Me.traffic_b_green.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_b_green.Location = New System.Drawing.Point(32, 232)
        Me.traffic_b_green.Name = "traffic_b_green"
        Me.traffic_b_green.Size = New System.Drawing.Size(126, 102)
        Me.traffic_b_green.Visible = False
        '
        'traffic_b_yellow
        '
        Me.traffic_b_yellow.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_b_yellow.BorderColor = System.Drawing.Color.Black
        Me.traffic_b_yellow.FillColor = System.Drawing.Color.Yellow
        Me.traffic_b_yellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_b_yellow.Location = New System.Drawing.Point(35, 120)
        Me.traffic_b_yellow.Name = "traffic_b_yellow"
        Me.traffic_b_yellow.Size = New System.Drawing.Size(126, 102)
        Me.traffic_b_yellow.Visible = False
        '
        'traffic_b_red
        '
        Me.traffic_b_red.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_b_red.FillColor = System.Drawing.Color.Red
        Me.traffic_b_red.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_b_red.Location = New System.Drawing.Point(36, 4)
        Me.traffic_b_red.Name = "traffic_b_red"
        Me.traffic_b_red.Size = New System.Drawing.Size(126, 102)
        '
        'groupbox3
        '
        Me.groupbox3.BackColor = System.Drawing.Color.Black
        Me.groupbox3.Controls.Add(Me.ShapeContainer3)
        Me.groupbox3.ForeColor = System.Drawing.Color.White
        Me.groupbox3.Location = New System.Drawing.Point(727, 204)
        Me.groupbox3.Name = "groupbox3"
        Me.groupbox3.Size = New System.Drawing.Size(200, 357)
        Me.groupbox3.TabIndex = 1
        Me.groupbox3.TabStop = False
        Me.groupbox3.Text = "Traffic Light 3"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.traffic_c_green, Me.traffic_c_yellow, Me.traffic_c_red})
        Me.ShapeContainer3.Size = New System.Drawing.Size(194, 338)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'traffic_c_green
        '
        Me.traffic_c_green.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_c_green.FillColor = System.Drawing.Color.Green
        Me.traffic_c_green.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_c_green.Location = New System.Drawing.Point(32, 232)
        Me.traffic_c_green.Name = "traffic_c_green"
        Me.traffic_c_green.Size = New System.Drawing.Size(126, 102)
        Me.traffic_c_green.Visible = False
        '
        'traffic_c_yellow
        '
        Me.traffic_c_yellow.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_c_yellow.BorderColor = System.Drawing.Color.Black
        Me.traffic_c_yellow.FillColor = System.Drawing.Color.Yellow
        Me.traffic_c_yellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_c_yellow.Location = New System.Drawing.Point(35, 120)
        Me.traffic_c_yellow.Name = "traffic_c_yellow"
        Me.traffic_c_yellow.Size = New System.Drawing.Size(126, 102)
        Me.traffic_c_yellow.Visible = False
        '
        'traffic_c_red
        '
        Me.traffic_c_red.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_c_red.FillColor = System.Drawing.Color.Red
        Me.traffic_c_red.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_c_red.Location = New System.Drawing.Point(36, 4)
        Me.traffic_c_red.Name = "traffic_c_red"
        Me.traffic_c_red.Size = New System.Drawing.Size(126, 102)
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.Controls.Add(Me.ShapeContainer4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(427, 451)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 357)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Traffic Light 4"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.traffic_d_green, Me.traffic_d_yellow, Me.traffic_d_red})
        Me.ShapeContainer4.Size = New System.Drawing.Size(194, 338)
        Me.ShapeContainer4.TabIndex = 0
        Me.ShapeContainer4.TabStop = False
        '
        'traffic_d_green
        '
        Me.traffic_d_green.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_d_green.FillColor = System.Drawing.Color.Green
        Me.traffic_d_green.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_d_green.Location = New System.Drawing.Point(32, 232)
        Me.traffic_d_green.Name = "traffic_d_green"
        Me.traffic_d_green.Size = New System.Drawing.Size(126, 102)
        Me.traffic_d_green.Visible = False
        '
        'traffic_d_yellow
        '
        Me.traffic_d_yellow.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_d_yellow.BorderColor = System.Drawing.Color.Black
        Me.traffic_d_yellow.FillColor = System.Drawing.Color.Yellow
        Me.traffic_d_yellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_d_yellow.Location = New System.Drawing.Point(35, 120)
        Me.traffic_d_yellow.Name = "traffic_d_yellow"
        Me.traffic_d_yellow.Size = New System.Drawing.Size(126, 102)
        Me.traffic_d_yellow.Visible = False
        '
        'traffic_d_red
        '
        Me.traffic_d_red.BackColor = System.Drawing.SystemColors.Control
        Me.traffic_d_red.FillColor = System.Drawing.Color.Red
        Me.traffic_d_red.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.traffic_d_red.Location = New System.Drawing.Point(36, 4)
        Me.traffic_d_red.Name = "traffic_d_red"
        Me.traffic_d_red.Size = New System.Drawing.Size(126, 102)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(828, 769)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(935, 769)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1014, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 26)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1054, 817)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupbox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intelligent Traffic  Control System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.groupbox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents traffic_a_red As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents traffic_a_green As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_a_yellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents traffic_b_green As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_b_yellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_b_red As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents groupbox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents traffic_c_green As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_c_yellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_c_red As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents traffic_d_green As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_d_yellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents traffic_d_red As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
