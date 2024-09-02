using Microsoft.AspNetCore.Http;

IHeaderDictionary headers1 = new HeaderDictionary();
headers1.TryGetValue("User-Agent", out var stringValues);

// case 1 - ok
string userAgent1 = stringValues.Count > 0
    ? string.Join(" ", stringValues) : string.Empty;

// case 2 - exception
string userAgent2 = string.Join(" ", stringValues);

Console.WriteLine("Finish");

// chat gpt
// Is that sentence true if we talk about c# from .net 6.0 :
// string.Join by default returns string.Empty if the collection has no elements therefore this check is unnecessary?

// Czy tym prymitywny moze być równy null?
// What is type of stringValues?
// Czy StringValues jest typem prymitywnym?
// Can stringValues be null?
// dlaczego stringvalues sa w przestrzeni typwo primities jezeli nie jes ttypem prymitywnym?


// Is that reallly tru that StringValues cannot be null?
// In that case why I have this error when I try use "is null" for stringValues
// Cannot convert 'null' to 'Microsoft. Extensions. Primitives. StringValues' because it is a non-nullable value type
//
// StringValues is a non-nullable value type (struct).
// This means you cannot assign null directly to a StringValues variable.
// Instead, you should use StringValues.
// Empty to represent an empty StringValues instance.
// If you need to handle a scenario where stringValues might be null,
// you should initialize it to StringValues.Empty before using it.
