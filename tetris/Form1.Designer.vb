<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        diddyPictureBox = New PictureBox()
        Timer1 = New Timer(components)
        coinPictureBox = New PictureBox()
        policePictureBox = New PictureBox()
        CType(diddyPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(coinPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(policePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' diddyPictureBox
        ' 
        diddyPictureBox.Image = CType(resources.GetObject("diddyPictureBox.Image"), Image)
        diddyPictureBox.Location = New Point(12, 25)
        diddyPictureBox.Name = "diddyPictureBox"
        diddyPictureBox.Size = New Size(68, 44)
        diddyPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        diddyPictureBox.TabIndex = 0
        diddyPictureBox.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' coinPictureBox
        ' 
        coinPictureBox.Image = CType(resources.GetObject("coinPictureBox.Image"), Image)
        coinPictureBox.Location = New Point(86, 25)
        coinPictureBox.Name = "coinPictureBox"
        coinPictureBox.Size = New Size(67, 44)
        coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        coinPictureBox.TabIndex = 1
        coinPictureBox.TabStop = False
        ' 
        ' policePictureBox
        ' 
        policePictureBox.Image = My.Resources.Resources.original1
        policePictureBox.Location = New Point(171, 12)
        policePictureBox.Name = "policePictureBox"
        policePictureBox.Size = New Size(81, 57)
        policePictureBox.SizeMode = PictureBoxSizeMode.Zoom
        policePictureBox.TabIndex = 2
        policePictureBox.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(644, 517)
        Controls.Add(policePictureBox)
        Controls.Add(coinPictureBox)
        Controls.Add(diddyPictureBox)
        Name = "Form1"
        Text = "Form1"
        CType(diddyPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(coinPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(policePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents diddyPictureBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents coinPictureBox As PictureBox
    Friend WithEvents policePictureBox As PictureBox

End Class
