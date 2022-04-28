import React from 'react'
import { Box } from '@mui/system'
export default function Banner() {
  return (
    <div>
         <Box sx={{
        display: 'flex',
        flexDirection: { xs: 'column', md: 'row' },
        alignItems: 'center',
        justifyContent:"center",
        overflow: 'hidden',
        borderRadius: '12px',
        boxShadow: 1,
        fontWeight: 'bold',
        mt:3
      }}>
        <Box
          component="img"
          src="https://salt.tikicdn.com/cache/w1080/ts/banner/b5/cf/e0/d31708318a90ae948329e9ca02a2ef27.png.webp"
        />
      </Box>
    </div>
  )
}
