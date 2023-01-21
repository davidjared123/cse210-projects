using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Nephi", "3", "7");
        Scripture scripture = new Scripture(scriptureReference, "And it came to pass that I, Nephi, said unto my father: I awill go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        Menu menu = new Menu(scriptureReference, scriptureMemorizer);

    }
}