using System;
using System.Windows.Forms;

namespace AppModeImage
{
    /// <summary>
    /// NOUVELLES NOTIONS : 
    ///     - Définir une classe qui lance des exceptions
    ///     - Utiliser un tableau d'objets
    ///     - Utiliser l'environnement de test de VisualStudio
    ///     
    /// TODO 01 : Ajouter la classe ModeImage au projet, compléter la classe en vous basant sur "Diagramme ModeImage.png"
    /// TODO 02 : Activer les tests pour la classe ModeImage dans le fichier "Correcteur.cs"
    /// TODO 03 : Compléter séquentiellement le fonctionnement des tests de la classe ModeImage jusqu'à ce qu'elle soit parfaite
    /// TODO 04 : Compléter le code de ce formulaire afin d'obtenir un fonctionnement identique à la version démo
    /// TODO 05 : Activer les tests du formulaire et s'assurer qu'ils fonctionnent parfaitement
    /// </summary>
    public partial class FrmPrincipal : Form
    {

        // Décommenter le code ci-dessous lorsque votre classe ModeImage sera totalement fonctionnelle
        private ModeImage[] m_tabModeImage; // un tableau contenant tous les modes images de l'application
        private int m_indexModeImage; // index du mode image courant
        public FrmPrincipal()
        {
            InitializeComponent();

            // Décommenter le code ci-dessous lorsque votre classe ModeImage sera totalement fonctionnelle

            m_tabModeImage = new ModeImage[3];
            m_tabModeImage[0] = new ModeImage("Sport", 90, 60, 50, 0, 6);
            m_tabModeImage[1] = new ModeImage("Jeu", 100, 70, 52, 1, 4);
            m_tabModeImage[2] = new ModeImage("Cinéma", 70, 40, 40, -1, 2);

            m_indexModeImage = 0;
            AfficherModeImageCourant();
        }
        public void AfficherModeImageCourant()
        {
            // À COMPLÉTER...
            ModeImage imageCourant = m_tabModeImage[m_indexModeImage];

            lblNomModeImage.Text = imageCourant.Nom;
            vsiLuminosité.Value = imageCourant.Luminosité;
            vsiContraste.Value = imageCourant.Contraste;
            vsiCouleur.Value = imageCourant.Couleur;
            vsiTeinte.Value = imageCourant.Teinte;
            vsiNetteté.Value = imageCourant.Netteté;


        }

        public void BtnModeImageSuivant_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            if (m_indexModeImage < 2)
            {
                m_indexModeImage++;
            }
            else
            {
                m_indexModeImage = 0;
            }

            AfficherModeImageCourant();
        }

        public void BtnMémoriser_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            ModeImage imageCourant = m_tabModeImage[m_indexModeImage];

            imageCourant.Luminosité = vsiLuminosité.Value;
            imageCourant.Contraste = vsiContraste.Value;
            imageCourant.Couleur = vsiCouleur.Value;
            imageCourant.Teinte = vsiTeinte.Value;
            imageCourant.Netteté = vsiNetteté.Value;

        }

        public void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vsiContraste_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
