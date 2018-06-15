namespace Battleship
{
    public struct Players
    {
        public Player Me;
        public Player Opponent;

        public Players(Player me, Player opponent){
            Me = me;
            Opponent = opponent;
        }
    }
}