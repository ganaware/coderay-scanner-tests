// https://msdn.microsoft.com/en-us/library/vstudio/cc713622.aspx

IEnumerable<string> sortDescendingQuery =
    from vegetable in vegetables
    orderby vegetable descending 
    select vegetable;
