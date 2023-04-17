namespace Wettkampf {
    internal class Ergebnis {
        Sportler sportler;
        float wert;
        public Ergebnis(Sportler sportler, float wert) {
            this.sportler = sportler;
            this.wert = wert;
        }
        public void SetSportler(Sportler sportler) {
            this.sportler = sportler;
        }
        public Sportler GetSportler() {
            return sportler;
        }
        public void SetWert(float wert) {
            this.wert = wert;
        }
        public float GetWert() {
            return wert;
        }
    }
}
