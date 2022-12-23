# SparkfishTwo
<pre>
Part 1
Let's say you need a sequence of numbers that can be used with LINQ for the purpose of some algorithm (e.g., 1, 2, 3,...). You can get an enumerator that can provide the sequence of numbers with something like Enumerable.Range(1, 100). That method returns an IEnumerable that generates that sequence on-the-fly without ever actually creating a proper data structure to hold all elements of the sequence. Now, let's say you had a dependency that required this sequence to be randomly accessed via an IList interface. Can you implement an IList that makes random access to a just-in-time return of the value in each "element" of the list? (so ... um, ToList() is not a valid answer here)

Here's one test to help gauge your implementation success: // Given a list of numbers ranging from 100 to 200 var list = new Listify(100, 200); // When I access index position 50 var val = list[50]; // Then I should get back a value of 150 val.Should().Equal(150);


Part 2
Now, we need to hook up that IList interface to do something super useful via a “microservice” (#buzzwords):
(1) If you don’t already have a free Azure dev account, go set that up now
(2) Set up a public repo on GitHub
(3) Create a WebAPI project that responds to GET requests on this endpoint route: /listify
(a) Accept begin / end range parameter values, in whatever way you think is most RESTful
(b) Accept a parameter to select the index within that range
(c) Return the value located in that index in whatever way you think is most RESTful
(4) Deploy this WebAPI endpoint into Azure



