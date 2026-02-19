import request from 'supertest';
import { app } from './index.js';
import { assert, describe, expect, it } from 'vitest';

// Unit test samples
describe('Dummy Unit Test', () => {
    it('', () => {
        expect(5).toBe(5);
    });
});

// E2E test samples
describe('E2E API Test', () => {
    it('', async () => {
        const res = await request(app).get('/hello');
        expect(res.statusCode).toBe(200);
        expect(res.text).toBe('Welcome to the Hack4Change Web Server.');
    });
});
