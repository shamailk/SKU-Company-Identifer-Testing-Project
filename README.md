# SKU-Identifer-Testing Project AIM Consulting Task
 I created the solution in Visual Studio .NET and added all the Happy Path tests to make sure the 200's are working as expected for all CRUD scenarios. 

# Issue
I had issues with the ID to delete and Get {ID} for a specific entries. When I look at the data there using the Get I see no field ID, so  I was not able to create all 
the test cases I wanted.Or Maybe I am not understanding if the ID was meant to be the SKU ID.  I tried using the SKU in the GET{id} and DELETE{id} requests. but it didn't 
work as expected

# GitHub
This is the first I used GITHub public reposistory for this solution. I hope you are able to download the solution and run it on Visual Studio. I usually use GIT On my Visual 
Studio with my work automation. 

# High Priority Test Cases I would have created if I would have figured out the ID data:  
1. After a Post I would Get ID/SKU to verify that specific ID did actually make into AWS (Back-end)

2. After Deleting an ID I would do a Get List to search for that particular ID to make sure it does NOT exist anymore

3. Corner case would be to search for data in the back-end to make sure all required fields are populated

4. Corner case would be to search for negative prices and NOT let them be added in a POST 

5. I would also create a E2E case doing a POST, Get that same entrie(s) that posted, then delelting the entries(s), and finally Getting the entry to make sure nothing is returned (Null or NOt found). 

6 For Load Tests I would hit the server at the ame timew with multiple clients (virtual users). This would give be a baseline of API behavior under load. 

# Any other questions or concerns please let me know. 
