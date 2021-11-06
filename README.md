# DesignPatterns.Facade
This is a demonstration from my DesignPattern series.

This is example was inspired by GoF.

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

In this example the client has to check if the customer is eligible for a bank loan.
However the library provided by the bank is too complex, which would make the client dependent on too many classes.

Here's where Facade kicks in. It can provide a simple interface for the client to use.
And if the bank library changes, only the Facade needs to change.

I personally feel that except those scenarios in which external libraries have to been used,
Facade kinda goes naturally just by respecting OOP and Single Responsability principles.
