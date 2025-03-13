namespace LB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ICard> cards = new List<ICard>()
        {
            new NormalCard("Charizard", Properties.Resources.charizard, 11),
            new NormalCard("Decidueye", Properties.Resources.decidueye, 8),
            new NormalCard("Dragonair", Properties.Resources.dragonair, 4),
            new NormalCard("Dratini", Properties.Resources.dratini, 3),
            new NormalCard("Gardevoir", Properties.Resources.gardevoir, 9),
            new NormalCard("Kommo-O", Properties.Resources.kommo_o, 10),
            new NormalCard("Mawile", Properties.Resources.mawile, 6),
            new NormalCard("Pikachu", Properties.Resources.pikachu_f, 5),
            new NormalCard("Rockruff", Properties.Resources.rockruff, 1),
            new NormalCard("Serperior", Properties.Resources.serperior, 7),
            new NormalCard("Zorua", Properties.Resources.zorua, 2),
            new ShinyCard("Charizard (Shiny)", Properties.Resources.charizard_shiny, 100, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Gold, System.Drawing.Color.Yellow),
            new ShinyCard("Decidueye (Shiny)", Properties.Resources.decidueye_shiny, 95, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Green, System.Drawing.Color.Yellow),
            new ShinyCard("Dragonair (Shiny)", Properties.Resources.dragonair_shiny, 93, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Purple, System.Drawing.Color.Yellow),
            new ShinyCard("Dratini (Shiny)", Properties.Resources.dratini_shiny, 92, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Pink, System.Drawing.Color.Yellow),
            new ShinyCard("Gardevoir (Shiny)", Properties.Resources.gardevoir_shiny, 99, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Blue, System.Drawing.Color.Yellow),
            new ShinyCard("Kommo-O (Shiny)", Properties.Resources.kommo_o_shiny, 98, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Yellow, System.Drawing.Color.Pink),
            new ShinyCard("Mawile (Shiny)", Properties.Resources.mawile_shiny, 97, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Gray, System.Drawing.Color.Yellow),
            new ShinyCard("Pikachu (Shiny)", Properties.Resources.pikachu_f_shiny, 94, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Orange, System.Drawing.Color.Yellow),
            new ShinyCard("Rockruff (Shiny)", Properties.Resources.rockruff_shiny, 91, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Blue, System.Drawing.Color.Yellow),
            new ShinyCard("Serperior (Shiny)", Properties.Resources.serperior_shiny, 96, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Green, System.Drawing.Color.Yellow),
            new ShinyCard("Zorua (Shiny)", Properties.Resources.zorua_shiny, 90, new System.Drawing.Font("Arial", 12, FontStyle.Bold), System.Drawing.Color.Brown, System.Drawing.Color.Yellow),
        };
        List<ICard> chosenCards = new List<ICard>();

        private void RandomCardChooser()
        {
            Random random = new Random();
            int normalCardIndex;
            int shinyCardIndex;

            while (chosenCards.Count < 10)
            {
                bool isShiny = false;
                int isShinyChance = random.Next(0, 101);
                if (isShinyChance <= 20)
                {
                    isShiny = true;
                }

                if (isShiny == true)
                {
                    shinyCardIndex = random.Next(11, 22); // doing (11,23) would throw an error (cause the list is only 22 entries), but it shouldn't ever get to 23? Making it 22 does the same thing though so it works.
                    int chosenShinyCard = shinyCardIndex;
                    chosenCards.Insert(0, cards[chosenShinyCard]);
                }
                else
                {
                    normalCardIndex = random.Next(0, 12);
                    ICard normalCard = cards[normalCardIndex];
                    chosenCards.Insert(0, normalCard);
                }
            }
        }
        private void DisplayCards()
        {
            for (int f = 0; f < chosenCards.Count; f++)
            {
                ICard card = chosenCards[f];

                PictureBox pbPokemon = Controls.Find($"pbPokemon{f + 1}", true).FirstOrDefault() as PictureBox;
                Label lblPokemon = Controls.Find($"lblPokemon{f + 1}", true).FirstOrDefault() as Label;

                if (pbPokemon != null && lblPokemon != null)
                {
                    card.ShowCard(pbPokemon, lblPokemon);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            RandomCardChooser();
            chosenCards.Sort((card1, card2) => card2.Value.CompareTo(card1.Value));
            DisplayCards();
            chosenCards.Clear();
        }
    }
}
