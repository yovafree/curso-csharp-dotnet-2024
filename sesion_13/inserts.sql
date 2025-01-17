-- Inserts para la tabla Category
INSERT INTO "Categories"("Id", "Name") VALUES
(1, 'Action'),
(2, 'Comedy'),
(3, 'Drama'),
(4, 'Horror'),
(5, 'Science Fiction');


INSERT INTO "Movies" ("Id", "Title", "Genre", "Year", "Director", "Actors", "Plot", "Poster", "ImdbRating", "ImdbId", "CategoryId") VALUES
(1, 'Inception', 'Science Fiction', 2010, 'Christopher Nolan', 'Leonardo DiCaprio, Joseph Gordon-Levitt', 'A thief who steals corporate secrets through dream-sharing technology is given the task of planting an idea into the mind of a CEO.', 'https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxOV5BMl5BanBnXkFtZTcwODI5OTM0Mw@@._V1_SX300.jpg', '8.8', 'tt1375666', 5),
(2, 'The Dark Knight', 'Action', 2008, 'Christopher Nolan', 'Christian Bale, Heath Ledger', 'Batman faces the Joker, a criminal mastermind who unleashes chaos on Gotham City.', 'https://m.media-amazon.com/images/M/MV5BOTY3NzYzNTI5MF5BMl5BanBnXkFtZTcwODE5NDk1Mw@@._V1_SX300.jpg', '9.0', 'tt0468569', 1),
(3, 'Interstellar', 'Science Fiction', 2014, 'Christopher Nolan', 'Matthew McConaughey, Anne Hathaway', 'A team of explorers travel through a wormhole in space in an attempt to ensure humanity’s survival.', 'https://m.media-amazon.com/images/M/MV5BMjIxNTU4MzY4NF5BMl5BanBnXkFtZTgwNzUxNjYzMTE@._V1_SX300.jpg', '8.6', 'tt0816692', 5),
(4, 'The Godfather', 'Drama', 1972, 'Francis Ford Coppola', 'Marlon Brando, Al Pacino', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 'https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmYtYTAwOS00ZjQ3LWEzYzctYzU3MGFjN2U3NTQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg', '9.2', 'tt0068646', 3),
(5, 'Pulp Fiction', 'Comedy', 1994, 'Quentin Tarantino', 'John Travolta, Uma Thurman', 'The lives of two mob hitmen, a boxer, a gangsters wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 'https://m.media-amazon.com/images/M/MV5BMjFlZjZmZTUtN2YyNi00Y2RlLWI5YmUtY2VkNmJjZmZjMDk1XkEyXkFqcGdeQXVyNDg5NjQxNjA@._V1_SX300.jpg', '8.9', 'tt0110912', 2),
-- Añade más registros con formato similar
(6, 'The Shawshank Redemption', 'Drama', 1994, 'Frank Darabont', 'Tim Robbins, Morgan Freeman', 'Two imprisoned men bond over several years, finding solace and eventual redemption through acts of common decency.', 'https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZWFmMy00ZDI1LWFmNTEtODM1NzBmZjE2MTBkXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg', '9.3', 'tt0111161', 3),
(7, 'The Matrix', 'Science Fiction', 1999, 'Lana Wachowski, Lilly Wachowski', 'Keanu Reeves, Laurence Fishburne', 'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.', 'https://m.media-amazon.com/images/M/MV5BNzQzOTk3NzAtMzI4Zi00ZGVkLWI1Y2EtZGEzNjIzZTk5OTdkXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg', '8.7', 'tt0133093', 5),
(8, 'Get Out', 'Horror', 2017, 'Jordan Peele', 'Daniel Kaluuya, Allison Williams', 'A young African-American man visits his white girlfriends family estate and becomes ensnared in a sinister plot.', 'https://m.media-amazon.com/images/M/MV5BMjMxMjMxNDgyNF5BMl5BanBnXkFtZTgwNzY1NjkzMTI@._V1_SX300.jpg', '7.7', 'tt5052448', 4),
(9, 'A Quiet Place', 'Horror', 2018, 'John Krasinski', 'Emily Blunt, John Krasinski', 'In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing.', 'https://m.media-amazon.com/images/M/MV5BMjQxNzMzMjMyOF5BMl5BanBnXkFtZTgwNzUzNDM3NDM@._V1_SX300.jpg', '7.5', 'tt6644200', 4),
(10, 'The Avengers', 'Action', 2012, 'Joss Whedon', 'Robert Downey Jr., Chris Evans', 'Earths mightiest heroes must come together and learn to fight as a team to stop a villain from destroying the planet.', 'https://m.media-amazon.com/images/M/MV5BMjAxMjExNDczNF5BMl5BanBnXkFtZTcwNTI5OTM0Nw@@._V1_SX300.jpg', '8.0', 'tt0848228', 1);