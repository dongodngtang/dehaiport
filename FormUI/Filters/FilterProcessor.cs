namespace FormUI.Filters
{
    public class FilterProcessor:Filter
    {
        public FilterProcessor(string[] content)
            : base(content)
        {
        }

        public override Filter Run()
        {
            return 
                new CallInFilter(
                new HangUpFilter(
                    new MessageFilter(
                        new ConnectFilter(
                            new ErrorFilter(this))))).Run();
        }

    }
}