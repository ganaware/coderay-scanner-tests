// https://msdn.microsoft.com/en-us/library/vstudio/cc713606.aspx

IEnumerable<string> sortAscendingQuery =
    from vegetable in vegetables
    orderby vegetable ascending 
    select vegetable;
