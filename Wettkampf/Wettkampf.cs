namespace Wettkampf {
    internal class Wettkampf {
        String name;
        Disziplin disziplin;
        List<Sportler> teilnehmer = new List<Sportler>();
        List<Ergebnis> ergebnisse = new List<Ergebnis>();
        public void SetName(String name) {
            this.name = name;
        }
        public String GetName() {
            return name;
        }
        public void SetDisziplin(Disziplin disziplin) {
            this.disziplin = disziplin;
        }
        public Disziplin GetDisziplin() {
            return disziplin;
        }
        public void AddSportler(Sportler sportler) {
            teilnehmer.Add(sportler);
        }
        public void PrintSportler() {
            foreach (Sportler item in teilnehmer) {
                Console.WriteLine(item.GetName());
            }
        }
        public void Ausgabe() {
            Console.WriteLine($"Ergebnis-Liste Disziplin: " + disziplin.GetName() + "/" + this.GetName());
            foreach (Ergebnis item in ergebnisse) {
                Console.WriteLine(item.GetSportler().GetName() + " " + item.GetWert());
            }
            Console.WriteLine("");
        }
        public void WettkampfDurchführen() {
            foreach (Sportler item in teilnehmer) {
                Random random = new Random();
                float wert = (float)random.NextDouble() * 10;
                Ergebnis ergebnis = new Ergebnis(item, wert);
                ergebnisse.Add(ergebnis);
            }
        }
    }
}
