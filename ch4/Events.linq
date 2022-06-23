<Query Kind="Expression" />

/*
 Events: construct that exposes just the subset of delegate features required for the broadcaster/subscri ber model. The main purpose of events is to prevent subscribes from interfearing with one another.
 
 Broadcaster: is a type that contains a delegate field. The broadcaster decides when to broadcast by invoking the delegate.
 
 Subscriber: the mehtod targer recipients. A subscriber decides when to start and stop listening by calling += and -= on the broadcaser's delegate. A subscriber does not know about, or interfere with, other subscribers.
*/