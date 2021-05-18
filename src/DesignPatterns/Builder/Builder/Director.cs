namespace Builder
{
    class Director
    {
        public static void Construct(Builder builder, string[] parts)
        {
            foreach (string part in parts)
                builder.BuildPart(part);
        }
    }
}
