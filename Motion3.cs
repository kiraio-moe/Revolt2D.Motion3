namespace Revolt2D.Motion.Json
{
    public class Motion3
    {
        public int Version;
        public Meta Meta;
        public List<Curve> Curves;

        public override string ToString()
        {
            string curvesString = string.Join("\n", Curves.Select((c, i) => $"  Curve[{i}]:\n{c}"));
            return $"Version: {Version}\nMeta:\n{Meta}\nCurves:\n{curvesString}";
        }
    }
}
