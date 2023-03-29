namespace Composite
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menu) { throw new ArgumentException(); }

        public virtual void remove(MenuComponent menu) { throw new ArgumentException(); }

        public virtual MenuComponent getChild(int index) {  throw new NotImplementedException(); }

        public virtual string getName() { throw new NotImplementedException(); }

        public virtual string getDescription() {  throw new NotImplementedException(); }

        public virtual double getPrice() { throw new NotImplementedException(); }

        public virtual bool isVegetarian() { throw new NotImplementedException(); }

        public virtual void print() { throw new NotImplementedException(); }
    }
}
