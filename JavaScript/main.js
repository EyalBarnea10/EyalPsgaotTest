

var appMoviesListSearch = angular.module('MoviesListSearchApp', []);
 
appMoviesListSearch.controller("mainMoviesListResultCtrl", function ($scope, $http, $window) {

    //after selected specific row 
    $scope.setSelected = function (movieSelectDetails) {
        $window.open("/MovieDetails.html", "_blank", "toolbar=yes,top=500,left=500,width=400,height=400");
        localStorage.setItem("views", movieSelectDetails.views);
        localStorage.setItem("title", movieSelectDetails.title);
        localStorage.setItem("seasons", movieSelectDetails.seasons);
        localStorage.setItem("details", movieSelectDetails.details);
        localStorage.setItem("image", movieSelectDetails.image);
    }
    var objMovies = new Array();
    $scope.searchOptions = ["title", "seasons", "views"];
    $.ajax({
        Type: 'GET',
        url: 'api/movies/',
        success: function (response) {
            movies = angular.fromJson(response);
            for (var i = 0; i < movies.length; i++) {
                objMovies[i] = {}
                objMovies[i].views = movies[i].views;
                objMovies[i].seasons = movies[i].seasons;
                objMovies[i].title = movies[i].title;
                objMovies[i].image = movies[i].image;
                objMovies[i].details = movies[i].details;
            }
            $scope.moviesListData = objMovies;
            $scope.$digest();
        }, error: function (err) {
            console.log("Error In getting movies List" + err)
        }
    });
 
})


 
