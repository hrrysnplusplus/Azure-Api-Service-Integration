# SparkfishTwo

Now, we need to hook up that IList interface to do something super useful via a “microservice” (#buzzwords):
(1) If you don’t already have a free Azure dev account, go set that up now
(2) Set up a public repo on GitHub
(3) Create a WebAPI project that responds to GET requests on this endpoint route: /listify
(a) Accept begin / end range parameter values, in whatever way you think is most RESTful
(b) Accept a parameter to select the index within that range
(c) Return the value located in that index in whatever way you think is most RESTful
(4) Deploy this WebAPI endpoint into Azure


Once you have it deployed, share the working Azure link and GitHub repo link.
If you want bonus points, or just for fun, set up the GitHub webhook integration so that your endpoint
auto-deploys to Azure after each commit. :)
