import { serveDir } from "https://deno.land/std@0.207.0/http/file_server.ts";

Deno.serve(async (req) => {
    return await serveDir(req, {
        fsRoot: "./public",
        urlRoot: "",
        showDirListing: true
    });

});
// deno run --allow-net server.ts