namespace TemplateMethod.Template
{
    public abstract class AbstractClass
    {
        protected abstract void Setup();
        protected abstract void Operation1();
        protected abstract void Operation2();
        protected abstract void TearDown();

        public void TemplateMethod()
        {
            Setup();
            Operation1();
            Operation2();
            TearDown();
        }
    }
}
