# C# Scanner

## It's not perfect

It does not parse C# codes after the real C# grammer,
but it parses them by a reasonably approximated way.

So, it sometimes makes mistakes, especially about contextual keywords.
( https://msdn.microsoft.com/en-us/library/vstudio/x53a06bb.aspx )

For example: "value" of k_explicit.in.cs and k_fale.in.cs .

## About test codes

Mainly, test codes are derived from Microsoft's C# Documentations
those URLs are written in the comment of "*.in.cs".
