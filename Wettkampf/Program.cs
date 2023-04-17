namespace Wettkampf {
    internal class Program {
        static void Main(string[] args) {
            Disziplin m100 = new Disziplin("100 Meter Lauf");
            Sportler s1 = new Sportler("Speedy");
            Sportler s2 = new Sportler("Jesse");
            Sportler s3 = new Sportler("Usain");

            Vorlauf vorlauf = new Vorlauf();
            Zwischenlauf zwischenlauf = new Zwischenlauf();
            Endlauf endlauf = new Endlauf();
            vorlauf.AddSportler(s1);
            vorlauf.AddSportler(s2);
            vorlauf.AddSportler(s3);
            vorlauf.SetDisziplin(m100);
            zwischenlauf.AddSportler(s1);
            zwischenlauf.AddSportler(s2);
            zwischenlauf.AddSportler(s3);
            zwischenlauf.SetDisziplin(m100);
            endlauf.AddSportler(s1);
            endlauf.AddSportler(s2);
            endlauf.AddSportler(s3);
            endlauf.SetDisziplin(m100);

            Ergebnis vl1 = new Ergebnis(s1, 1.0f);
            Ergebnis vl2 = new Ergebnis(s2, 2.0f);
            Ergebnis vl3 = new Ergebnis(s3, 3.0f);
            Ergebnis zl1 = new Ergebnis(s1, 0.9f);
            Ergebnis zl2 = new Ergebnis(s2, 1.5f);
            Ergebnis zl3 = new Ergebnis(s3, 1.7f);
            Ergebnis el1 = new Ergebnis(s1, 0.7f);
            Ergebnis el2 = new Ergebnis(s2, 0.9f);
            Ergebnis el3 = new Ergebnis(s3, 0.99f);

            zwischenlauf.WettkampfDurchführen();
            vorlauf.WettkampfDurchführen();
            endlauf.WettkampfDurchführen();

            vorlauf.Ausgabe();
            zwischenlauf.Ausgabe();
            endlauf.Ausgabe();
        }
    }
}