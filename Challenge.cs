public class Challenge
{
    public class OutType
    {
        public int Number { get; set; }
        public int Count { get; set; }
    }

    public string Name { get; set; }
    public int[] Ins { get; set; }
    public OutType[] Outs { get; set; }
    public float Difficulty { get; set; }
}