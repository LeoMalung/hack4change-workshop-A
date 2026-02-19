# JS-Express Sample Application

A sample web server in Javascript.

## Requirements
- `yarn` or `npm` as a package manager
- `nodejs` 

## Setup Process

You should have `yarn` or `npm` installed, and an up to date `nodejs`. Any IDE you're comfortable with is fine. I think there are general suggestions if you're new to this.

Run `yarn` or `npm install` from the root directory to install your dependencies and you are ready to go. This is something most IDEs will also do for you.

## Commands

### Dev server

This will continuously transpile your code and tell you why it's not happy.

`yarn dev` or `npm run dev`

### Tests

This will watch your files for changes and rerun tests when it sees them

`yarn test` or `npm run test`

### Building

This will compile your app into the `./dist` directory for deployment

`yarn build` or `npm run build`

### Running

If you build, or have the dev server running, you will have the most recent version in `./dist` (if there are no errors). 

You can then run the app with `yarn start` or `npm run start`

From there, you should be able to connect to http://localhost:8081 and access your server.

## Reference Material

If you want to take a deeper dive into Express you can find its documentation here: https://expressjs.com/en/starter/hello-world.html
