namespace Wettkampf {
    internal class Sportler {
        String name;
        public Sportler(String name) {
            this.name = name;
        }
        public void SetName(String name) {
            this.name = name;
        }
        public String GetName() {
            return name;
        }
    }
}
