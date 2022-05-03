namespace MyLibrary
{
    public class CalculateFradrag
    {
        const double kmFradrag25_120km = 2.16; const double kmFradragOver120km = 1.08;
        double fradragetsVærdi = 0.26;

        public double RunCalulationOfFradrag(int kørtKm, int dage)
        {
            //double resultatUnder120km = 0; double resultatOver120km = 0; double endeligResultat;

            if (kørtKm > 120)
            {
                double res = DistanceBetween24And120Km(kørtKm, dage) + DistanceFrom120Km(kørtKm, dage);
                res = (res * fradragetsVærdi);
                return Math.Round(res);
            }
            else if (kørtKm > 24)
            {
                return Math.Round(DistanceBetween24And120Km(kørtKm, dage) * fradragetsVærdi);
            }
            else
            {
                return 0;
            }
        }

        private double DistanceBetween24And120Km(int kørtKm, int dage)
        {
            if (kørtKm > 120)
                kørtKm = 96;
            else
                kørtKm -= 24;

            return kørtKm * kmFradrag25_120km * dage;
        }

        private double DistanceFrom120Km(int kørtKm, int dage)
        {
            kørtKm -= 120;

            return kørtKm * kmFradragOver120km * dage;
        }
    }
}