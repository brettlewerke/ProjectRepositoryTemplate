# Definition of Done
- Verify that existing unit tests do not fail; if they do, fix them
- Add unit tests and have provided instructions in pull request for how to test (if relevant)
- Verify that changes do not introduce new warnings or errors in code analysis tools (i.e. SonarQube, etc.)
- Add documentation (if needed) in markdown with mermaid diagrams or other depictions as necessary.
- General solution documentation should be in the `docs` folder with other area-specific documentation in the appropriate subfolder (i.e. testing documentation would go under `testing`, etc.).
- Comment code for legibility, particularly in hard-to-understand areas. Additionally, code that handles strange edge cases or other odd behavior should be clearly explained __why__ the code is written in that way.
- Most code should be self-documenting, but comments are useful for complex logic.
- Do not decrease testing coverage (if coverage has been set up)
