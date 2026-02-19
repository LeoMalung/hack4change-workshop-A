import express from 'express';
export const app = express();

app.get('/hello', (req: any, res: any) => {
    res.send('Welcome to the Hack4Change Web Server.')
})

