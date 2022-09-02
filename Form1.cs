namespace SpaceClicker
{
    public partial class SpaceForm : Form
    {
        Player player;

        public SpaceForm()
        {
            InitializeComponent();
            player = new Player();

        }

        public void SwapShipPhoto()
        {
            //shipPicture.Image = Image.FromFile("./Pictures/planets/" +  Ships.FileNames[player.shipLevel]);
        }

        public void SwapPlanetPhoto()
        {
            //planetPicture.Image = Image.FromFile("./Pictures/planets/" + Planets.FileNames[player.planetLevel]);
        }

        public void UpdateLabels()
        {
            creditsTxtBox.Text = player.credits.ToString();

            shuttleButton.Text = "§" + Shuttle.cost.ToString();
            shuttleLabel.Text = Shuttle.displayName + ": " + Shuttle.amount.ToString();

            fighterButton.Text = "§" + Fighter.cost.ToString();
            fighterLabel.Text = Fighter.displayName + ": " + Fighter.amount.ToString();

            haulerButton.Text = "§" + Hauler.cost.ToString();
            haulerLabel.Text = Hauler.displayName + ": " + Hauler.amount.ToString();

            exoticButton.Text = "§" + ExoticShip.cost.ToString();
            exoticLabel.Text = ExoticShip.displayName + ": " + ExoticShip.amount.ToString();

            freighterButton.Text = "§" + Freighter.cost.ToString();
            freighterLabel.Text = Freighter.displayName + ": " + Freighter.amount.ToString();

            planetButton.Text = "§" + Planets.PlanetCosts[player.planetLevel + 1].ToString();
            planetLabel.Text = "Planet Level: " + player.planetLevel.ToString() + " " + Planets.PlanetNames[player.planetLevel];

            shipButton.Text = "§" + Ships.ShipCosts[player.shipLevel + 1].ToString();
            shipLabel.Text = "Ship Level: " + player.shipLevel.ToString();
        }

        public void enableDisableButtons()
        {
            if(player.credits < Shuttle.cost)
                shuttleButton.Enabled = false;
            else
                shuttleButton.Enabled = true;

            if (player.credits < Fighter.cost)
                fighterButton.Enabled = false;
            else
                fighterButton.Enabled = true;

            if(player.credits < Hauler.cost)
                haulerButton.Enabled = false;
            else
                haulerButton.Enabled = true;

            if(player.credits < ExoticShip.cost)
                exoticButton.Enabled = false;
            else
                exoticButton.Enabled = true;

            if (player.credits < Freighter.cost)
                freighterButton.Enabled = false;
            else
                freighterButton.Enabled = true;

            if (player.credits < Planets.PlanetCosts[player.planetLevel + 1])
                planetButton.Enabled = false;
            else
                planetButton.Enabled = true;

            if (player.credits < Ships.ShipCosts[player.shipLevel + 1])
                shipButton.Enabled = false;
            else
                shipButton.Enabled = true;


        }

        private void SpaceForm_Load(object sender, EventArgs e)
        {
            gamerTime.Enabled = true;
            shuttleTimer.Enabled = true;
            fighterTimer.Enabled = true;
            haulerTimer.Enabled = true;
            exoticShipTimer.Enabled = true;
            freighterTimer.Enabled = true;
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            player.credits += Ships.ShipClick[player.shipLevel];
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
        }

        private void gamerTime_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
            enableDisableButtons();
        }

        private void shuttleButton_Click(object sender, EventArgs e)
        {
            if(player.credits >= Shuttle.cost)
            {
                Shuttle.amount += 1;
                player.credits -= Shuttle.cost;
                //increase shuttle cost
            }
        }

        private void fighterButton_Click(object sender, EventArgs e)
        {
            if(player.credits >= Fighter.cost)
            {
                Fighter.amount += 1;
                player.credits -= Fighter.cost;
                //increase fighter cost
            }
        }

        private void exoticButton_Click(object sender, EventArgs e)
        {
            if(player.credits >= ExoticShip.cost)
            {
                ExoticShip.amount += 1;
                player.credits -= ExoticShip.cost;
                //increase exotic ship cost
            }
        }

        private void haulerButton_Click(object sender, EventArgs e)
        {
            if(player.credits >= Hauler.cost)
            {
                Hauler.amount += 1;
                player.credits -= Hauler.cost;
                //increase hault cost
            }
        }

        private void freighterButton_Click(object sender, EventArgs e)
        {
            if(player.credits >= Freighter.cost)
            {
                Freighter.amount++;
                player.credits -= Freighter.cost;
                //increase freighter cost
            }
        }

        private void fighterTimer_Tick(object sender, EventArgs e)
        {
            player.credits += (int)(Planets.PlanetBonus[player.planetLevel] * (Fighter.amount * Fighter.moneyPerTick));
        }

        private void shuttleTimer_Tick(object sender, EventArgs e)
        {
            player.credits += (int)(Planets.PlanetBonus[player.planetLevel] * (Shuttle.amount * Shuttle.moneyPerTick));
        }

        private void haulerTimer_Tick(object sender, EventArgs e)
        {
            player.credits += (int)(Planets.PlanetBonus[player.planetLevel] * (Hauler.amount * Hauler.moneyPerTick));
        }

        private void exoticShipTimer_Tick(object sender, EventArgs e)
        {
            player.credits += (int)(Planets.PlanetBonus[player.planetLevel] * (ExoticShip.amount * ExoticShip.moneyPerTick));
        }

        private void freighterTimer_Tick(object sender, EventArgs e)
        {
            player.credits += (int)(Planets.PlanetBonus[player.planetLevel] * (Freighter.amount * Freighter.moneyPerTick));
        }

        private void planetButton_Click(object sender, EventArgs e)
        {
            player.planetLevel++;
            SwapPlanetPhoto();
        }

        private void shipButton_Click(object sender, EventArgs e)
        {
            player.shipLevel++;
            SwapShipPhoto();
        }
    }

    public partial class Player
    {
        public int credits;
        public int shipLevel;
        public int planetLevel;


        public Player()
        {
            this.credits = 0;
            this.shipLevel = 0;
            this.planetLevel = 0;
        }

    }

    public static class Ships
    {
        public static int[] ShipClick = { 1, 2, 10, 20, 100, 500, 1000, 5000, 200000, 500000 };
        public static int[] ShipCosts = { 0, 100, 10000, 30000, 40000, 50000, 100000, 500000, 750000, 1000000 };
        public static string[] FileNames = { "ship0.jpg", "ship1.jpg", "ship2.jpg" };
    }

    public static class Planets
    {
        public static double[] PlanetBonus = { 1, 1.5, 2, 2.5, 3.5, 5, 7, 10, 15 };
        public static int[] PlanetCosts = { 0, 100, 10000, 30000, 40000, 50000, 100000, 500000, 750000, 1000000 };
        public static string[] PlanetNames = { "Earth", "Mars", "Venus", "Mercury", "Jupiter", "Saturn", "Uranus", "Neptune", "Naboo", "Reach" };
        public static string[] FileNames = {"earth.jpg", "mars.jpg", "venus.jpg", "mercury.jpg" };

    }

    public static class Shuttle
    {
        public static string displayName = "Shuttle";

        public static string description = "Makes 1 credit every 2 seconds";

        public static int cost = 100;

        public static int amount = 0;

        public static int moneyPerTick = 1;
    }

    public static class Fighter
    {
        public static string displayName = "Fighter";

        public static string description = "Makes 10 credits every 5 seconds";

        public static int cost = 100;

        public static int amount = 0;

        public static int moneyPerTick = 10;
    }

    public static class Hauler
    {
        public static string displayName = "Hauler";

        public static string description = "Makes 50 credits every 10 seconds";

        public static int cost = 5000;

        public static int amount = 0;

        public static int moneyPerTick = 50;
    }

    public static class ExoticShip
    {
        public static string displayName = "Exotic Ship";

        public static string description = "Makes 1000 credits every 15 seconds";

        public static int cost = 15000;

        public static int amount = 0;

        public static int moneyPerTick = 1000;
    }

    public static class Freighter
    {
        public static string displayName = "Freighter";

        public static string description = "Makes 10,000 credits every 20 seconds";

        public static int cost = 50000;

        public static int amount = 0;

        public static int moneyPerTick = 10000;
    }
}