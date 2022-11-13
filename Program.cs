// See https://aka.ms/new-console-template for more information

using practice_two;

var core = new Core();

core.Init();

Console.WriteLine( "Register Test" );

var result = core.Register( "juan@gmail.com", "123456" );
Console.WriteLine( result );

var result2 = core.Register( "juan2@gmail.com", "123456" );

Console.WriteLine( result2 );
Console.WriteLine( "------" );


Console.WriteLine( "Login Test" );
var loginr1 = core.Login("jua@gmail.com", "123456");
Console.WriteLine( loginr1 );

var loginr2 = core.Login("juan@gmail.com", "1234567");
Console.WriteLine( loginr2 );

var loginr3 = core.Login("juan@gmail.com", "123456");
Console.WriteLine( loginr3 );