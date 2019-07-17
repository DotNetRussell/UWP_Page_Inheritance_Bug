# UWP Page Inheritance Bug


Related Stack Overflow Question: https://stackoverflow.com/questions/57064473/creating-a-subclass-of-page-in-uwp

I believe this might be a bug in the UWP platform. 

**Issue Summary:**

When subclassing page, you're unable to modify its control template. You can't restyle it. You can't create a subclass of it and provide your own template. Basically any modification of the UI of Page doesn't work as far as I can tell. 
