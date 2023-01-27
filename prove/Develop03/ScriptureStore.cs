class ScriptureStore
{

    private List<string> store;
    ScriptureStore(List<string> _store)
    {
        Tuple<string, string> store1 = new Tuple<string, string>("1 Nefi 3:7", "Ire y hare");
        Tuple<string, string> store2 = new Tuple<string, string>("2 Nefi 2:27", "2 nefi");
        Tuple<string, string> store3 = new Tuple<string, string>("Alma 37:33", "alma");

        _store.Add(store1.ToString());

    }

    public void printStore(string _store)
    {
        Console.Write(_store);
    }
}