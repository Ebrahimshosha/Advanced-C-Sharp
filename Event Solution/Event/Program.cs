namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();
            Player player1 = new Player() { Name = "Cr7", Team = "Al-Nasr" };
            Player player2 = new Player() { Name = "mani", Team = "Al-Nasr" };
            Player player3 = new Player() { Name = "Benzema", Team = "Al-Ethad" };
            Player player4 = new Player() { Name = "kante", Team = "Al-Ethad" };

            Refree refree = new Refree() { Name = "jakson" };

            // subscribe
            ball.OnLocationChanged += player1.Run;
            ball.OnLocationChanged += player2.Run;
            ball.OnLocationChanged += player3.Run;
            ball.OnLocationChanged += player4.Run;

            ball.OnLocationChanged += refree.Look;

            ball.BallLocation = new Location() { X = 0, Y = 10, Z = 20 };
            ball.BallLocation = new Location() { X = 10, Y = 20, Z = 40 };




        }
    }
}