# Introduction

Welcome to Wegmans Automation demo utilizing C# Selenium!
This repository is a curated portfolio designed to give a quick insight of my thought process when it comes to automation testing, problem-solving, and coding style using C# and Selenium WebDriver - it is by no means meant for a full E2E suite demonstration.

# What This Project Covers

## C# Coding Style
    Demonstrates my approach to clean, maintainable, and efficient coding in C#.
## Selenium WebDriver Utilization
Showcases the use of Selenium WebDriver for browser automation, along with best practices.
## Problem Solving
Real-world examples of how I approach and solve testing challenges.
## Project Structure
Below is the hierarchy of the project 

    /
    ├── pages/      # Page objects
    ├── tests/      # Tests and test cases
    ├── utils/      # Utilities, shared components

## Getting Started

1. `git clone https://github.com/lwskosa/WegmansDemo-MainSite.git`
2. Open solution in Visual Studio
3. OPTIONAL: In `WegmansDemo-MainSite\App.config` change `browser` key value from `Chome` to desired/required browser:
   * `Chrome` 
   * `Edge`
   * `Firefox`
   * In a QA/PROD setting this would be expanded further to include required browsers
4. Build Solution
5. Open `Test Explorer` in Visual Studio to see available test cases and run them

## Used Packages
* Configuration Manager
* DotNet Selenium, Extras
* NUnit
* WebDriverManager

## Additional Information
The locators were used as-is, in a live environment this would be communicated to DEV team to which elements need (better) locators. Instead of spending effort on trying to figure out problematic locators - plenty of which are likely to become obsolete during development - I think it is important to ensure appropriate test environment with the help of DEV team.