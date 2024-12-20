<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_livre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_livre))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Txt_isbn = New TextBox()
        Txt_titre = New TextBox()
        Txt_auteur = New TextBox()
        Button1 = New Button()
        Btn_ajouter = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Location = New Point(222, 54)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.Size = New Size(100, 23)
        Txt_isbn.TabIndex = 3
        ' 
        ' Txt_titre
        ' 
        Txt_titre.Location = New Point(222, 135)
        Txt_titre.Name = "Txt_titre"
        Txt_titre.Size = New Size(100, 23)
        Txt_titre.TabIndex = 4
        ' 
        ' Txt_auteur
        ' 
        Txt_auteur.Location = New Point(222, 221)
        Txt_auteur.Name = "Txt_auteur"
        Txt_auteur.Size = New Size(100, 23)
        Txt_auteur.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(557, 102)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.Location = New Point(557, 186)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(75, 23)
        Btn_ajouter.TabIndex = 7
        Btn_ajouter.Text = "Ajouter"
        Btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' frm_livre
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_ajouter)
        Controls.Add(Button1)
        Controls.Add(Txt_auteur)
        Controls.Add(Txt_titre)
        Controls.Add(Txt_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_livre"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_titre As TextBox
    Friend WithEvents Txt_auteur As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_ajouter As Button

End Class
