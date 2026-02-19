# Sample Java Spring Boot Server

## Requirements

- A `jdk` that's version 17+
- `maven` package manager

## Setup

Run `mvn compile` and it should download your dependencies and confirm that it compiled. Most IDEs will manage this for you from the `pom.xml`.

`IntelliJ` and `Eclipse` are popular ones.

## Scripts

### Dev Server

Run `mvn spring-boot:run`. Everytime you recompile it will reload the server. You can access it at `http://localhost:8081`.

### Testing

If you just want to run unit tests (faster) run `mvn test -DexcludedGroups=integration`

If you have the dev server up and running, run `mvn test` and it will run the e2e tests as well.

### Compiling

`mvn compile` will attempt to compile your code and tell you if anything is wrong.

### Deploying

`mvn package -DexcludedGroups=integration` will run unit tests, then build a jar file in the `./target` directory.

You can run the jar file with `java -jar ./file` and it will serve the application on port 8081.
