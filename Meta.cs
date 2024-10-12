namespace Revolt2D.Motion.Json
{
    public class Meta
    {
        public double Duration;
        public double Fps;
        public bool Loop;
        public bool AreBeziersRestricted;
        public int CurveCount;
        public int TotalSegmentCount;
        public int TotalPointCount;
        public int UserDataCount;
        public int TotalUserDataSize;

        public override string ToString()
        {
            return $"    Duration: {Duration}\n    Fps: {Fps}\n    Loop: {Loop}\n    Are Beziers Restricted: {AreBeziersRestricted}\n    Curve Count: {CurveCount}\n    Total Segment Count: {TotalSegmentCount}\n    Total Point Count: {TotalPointCount}\n    User Data Count: {UserDataCount}\n    Total User Data Size: {TotalUserDataSize}";
        }
    }
}
