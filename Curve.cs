namespace Revolt2D.Motion.Json
{
    public class Curve
    {
        public string Target;
        public string Id;
        public List<double> Segments;

        public override string ToString()
        {
            string segmentsString = string.Join(", ", Segments.Select((s, i) => s));
            return $"    Target: {Target}\n    Id: {Id}\n    Segments [{Segments?.Count}]: {segmentsString}";
        }
    }
}
