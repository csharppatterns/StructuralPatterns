# StructuralPatterns
Structural patterns are concernedaccross with how classes and objects are composed to form larger structures.

## Decorator Pattern
Decorator pattern attaches additional behavior without inheritance.

## Proxy Pattern
Proxy pattern controls the creation of and access to others objects.
There are several kinds of proxies:
 - Virtual proxies. Hands creation of an object over to another object.
 - Authentication proxies. Checks the access permissions for a request.
 - Remote proxies. Sends requests across the network.
 - Smart proxies. Changes requests before sending them on.

## Bridge Pattern
Bridge pattern separates an abstraction from its implementation. It is useful when a new version of software should replace an existing version, but the older version must still run for its existing client base.

## Composite Pattern
Composite pattern arranges structured hierarchies so that single components and groups of components can be treated in the same way. Pattern has to deal with two types: Components and Composites of those components. Both types should implement common operations of the same interface.

## Flyweight Pattern
Flyweight pattern promotes an efficient way to share common information present in small objects that occur in a system in large numbers.

## Adapter Pattern
Adapter Pattern is useful wherever there is code to be wrapped up and redirected to a different implementation. Adapter can put in varying amounts of work to adapt base implementation to new interface. The simplest adaption is just to reroute a method call to one of a different name.

