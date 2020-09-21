using System;

namespace ProblemsApi.Helpers
{
    public class Intersection
    {
        public static int CountIntersect(Rectangles rectangles)
        {
            Rectangle rectA = rectangles.RectA;
            Rectangle rectB = rectangles.RectB;

            //Area ReactA
            int areaRectA = Math.Abs(rectA.L.X - rectA.R.X) * Math.Abs(rectA.L.Y - rectA.R.Y);

            //Area Reactb
            int areaRectB = Math.Abs(rectB.L.X - rectB.R.X) * Math.Abs(rectB.L.Y - rectB.R.Y);

            //Area Intersect
            int areaI = Math.Max(0, Math.Min(rectA.R.X, rectB.R.X) - Math.Max(rectA.L.X, rectB.L.X)) *
             Math.Max(0, Math.Min(rectA.R.Y, rectB.R.Y) - Math.Max(rectA.L.Y, rectB.L.Y));

            int x1 = Math.Min(rectA.R.X, rectB.R.X);
            int x2 = Math.Max(rectA.L.X, rectB.L.X);
            int y1 = Math.Min(rectA.R.Y, rectB.R.Y);
            int y2 = Math.Max(rectA.L.Y, rectB.L.Y);
            int areaFinal = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);


            return (areaRectA + areaRectB - areaI);
        }

    }
}