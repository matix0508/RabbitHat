﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class Project
    {

        public string Name { get; set; }
        public Technology Technology { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Image { get; set; }

        public Project(string name, Technology tech, DateTime start, DateTime end)
        {
            Name = name;
            Technology = tech;
            StartingTime = start;
            EndTime = end;
        }
        public Project()
        {

        }

        public Project(string name, string tech, DateTime start)
        {
            Name = name;
            Technology = new Technology(tech);
            StartingTime = start;
        }

        public Project(string name, string tech, DateTime start, string url)
        {
            Name = name;
            Technology = new Technology(tech);
            StartingTime = start;
            URL = url;
        }

        public Project(string name, Technology tech, DateTime start, string url)
        {
            Name = name;
            Technology = tech;
            StartingTime = start;
            URL = url;
        }

        public static Project[] GetExample()
        {
            Technology Unity = new Technology("Unity", "Images/Technologies/Unity.png");
            Technology Python = new Technology("Python", "Images/Technologies/Python.png");
            Technology Blazor = new Technology("Blazor", "Images/Technologies/Blazor.png");

            Project Sudoku = new Project("SudokuSolver", Unity, new DateTime(2020, 12, 28), "https://simmer.io/@matix0508/sudokusolver")
            {
                Description = "Short Description",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg/1200px-Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg.png"
            };
            Project RabbitHat = new Project("RabbitHat", Blazor, new DateTime(2020, 12, 28), "/")
            {
                Description = "Short Description",
                Image = "Images/RabbitHat.png"
            };
            Project Korwin = new Project("Korwin", Unity, new DateTime(2020, 11, 28), "https://simmer.io/@matix0508/korwin")
            {
                Description = "Short Description",
                Image = "https://pbs.twimg.com/profile_images/593430376443445248/m99ZwQgD.jpg"
            };

            Project FlappyBird = new Project("Flappy Bird", Python, new DateTime(2020, 07, 14), "https://github.com/matix0508/flappy_bird")
            {
                Description = "AI",
                Image = "https://banner2.cleanpng.com/20180509/clq/kisspng-flappy-bird-blue-flappy-escape-gamesonomy-0-5af276810bdb85.4428883815258394890486.jpg"
            };
            var result = new List<Project>()
            {
                Sudoku,
                RabbitHat,
                Korwin,
                FlappyBird
            };
            return result.ToArray();
        }


    }
}