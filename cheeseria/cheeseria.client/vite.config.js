import { fileURLToPath, URL } from 'node:url';

import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-vue';

import { env } from 'process';
import basicSsl from '@vitejs/plugin-basic-ssl'





const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
    env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'https://localhost:8081';

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [plugin(), basicSsl()],
    resolve: {
        alias: {
            '@': fileURLToPath(new URL('./src', import.meta.url))
        }
    },
    server: {
        proxy: {
            '/api': {
                target: 'https://cheeseria:8081',
                secure: false
            }
        },
        watch: {
            usePolling: true,
        },
        strictPort: true,
        port: 5180,
        host: true,
        https: true
    }
})
