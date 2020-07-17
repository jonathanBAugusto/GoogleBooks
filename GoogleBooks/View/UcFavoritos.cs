using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GoogleBooks.Model;

namespace GoogleBooks.View
{
    public partial class UcFavoritos : UserControl
    {
        public static FlowLayoutPanel flowPanel = null;
        public static void loadFlowPanel(List<Favorite> favorites)
        {
            if (flowPanel != null)
            {
                favorites.ForEach(favorite =>
                {
                    UcCardFavorito card = new UcCardFavorito(favorite);
                    card.Name = "card" + favorite.id;
                    card.Anchor = AnchorStyles.Left;
                    flowPanel.Controls.Add(card);
                });
                flowPanel.Refresh();
            }
        }
        public UcFavoritos()
        {
            InitializeComponent();
            fpnlFavoritos.VerticalScroll.Enabled = false;
            fpnlFavoritos.VerticalScroll.Visible = false;
        }

        ~UcFavoritos()
        {
            flowPanel = null;
        }

        private void UcFavoritos_Load(object sender, EventArgs e)
        {
            flowPanel = fpnlFavoritos;
            loadFlowPanel(Favorite.getAll().ToList());
        }

        public static void removeFromList(string id)
        {
            flowPanel.Controls.Remove(UcFavoritos.flowPanel.Controls.Find("card" + id, true).FirstOrDefault());

            flowPanel.Refresh();
        }
        public static void addToList(Favorite favorite)
        {
            UcCardFavorito card = new UcCardFavorito(favorite);
            card.Name = "card" + favorite.id;
            flowPanel.Controls.Add(card);

            flowPanel.Refresh();
        }
    }
}
