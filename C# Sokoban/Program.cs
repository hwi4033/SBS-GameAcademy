namespace C__Sokoban
{
    public class Stage
    {
        List<int[,]> stages = new List<int[,]>();

        int[,] stage1 = new int[7, 7] {
                {0,0,1,1,1,1,0 },
                {0,0,1,0,0,1,0 },
                {1,1,1,0,0,1,0 },
                {1,0,2,3,0,1,1 },
                {1,0,2,0,3,0,1 },
                {1,1,1,0,0,0,1 },
                {0,0,1,1,1,1,1 }
            };
        public int[,] stage2 = new int[9, 9] {
            {1,1,1,1,1,0,0,0,0 },
            {1,0,0,0,1,0,0,0,0 },
            {1,0,0,0,1,0,1,1,1 },
            {1,0,0,0,1,0,1,2,1 },
            {1,1,1,0,1,1,1,2,1 },
            {0,1,1,0,0,0,0,2,1 },
            {0,1,0,0,0,1,0,0,1 },
            {0,1,0,0,0,1,1,1,1 },
            {0,1,1,1,1,1,0,0,0 }
        };

        public Stage()
        {
            stages.Add(stage1);
            stages.Add(stage2);
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}