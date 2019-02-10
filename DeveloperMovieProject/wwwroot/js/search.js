var request = null;

function search()
{
    var query = document.getElementById("search").value;
    var output = "";
    if(query == null || query ==="" || query.length < 3) return;
    if(request != null) request.abort();

    output = "<img width='423px' height='98px' src='../images/loading.gif' alt='loading...'></img>";
    displayResults(output);
    request = $.ajax({
        type: "GET",
        url: "search/" + query,
        datatype: "text",
        success: function(results) {
            var count = results.length;
            if(count <= 0) 
            {
                output = "<p>No results found.</p>"
                displayResults(output);
                return;
            }

            output = "<table class='table table-sm table-striped'>";
            for (movie in results)
            {
                output += "<tr><td>" + results[movie].title + " (" + results[movie].year + ")</td></tr></li>";
            }
            output += "</table><p class='text-primary'>" + count + " movies found.";
            displayResults(output);
        }
    });
}

function displayResults(results)
{
    document.getElementById("results").innerHTML = results;
}