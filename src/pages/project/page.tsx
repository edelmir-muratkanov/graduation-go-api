import { Tabs, TabsList, TabsTrigger } from '@/components/ui'

import { ProjectCalculations } from './project-calculations/project-calculations'
import { ProjectInfo } from './project-info/project-info'
import { useProjectPage } from './useProjectPage'

export const ProjectPage = () => {
  const { state, functions } = useProjectPage()

  return (
    <Tabs
      className='w-full space-y-10'
      value={state.tab}
      defaultValue='info'
      onValueChange={functions.hanleTabsValueChange}
      orientation='vertical'
    >
      <TabsList>
        <TabsTrigger value='info'>Info</TabsTrigger>
        <TabsTrigger value='calculations'>Calculations</TabsTrigger>
      </TabsList>

      <ProjectInfo />
      <ProjectCalculations />
    </Tabs>
  )
}
